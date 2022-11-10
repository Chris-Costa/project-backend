using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public WorkoutController(IUserService userService, IMapper mapper) 
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Workout>>> GetAllofUsersWorkouts(int userId)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }
        var userWorkouts = await _userService.GetAllofUsersWorkouts(userId);

        return Ok(_mapper.Map<IEnumerable<Workout>>(userWorkouts));
    }
    
    [HttpGet("{workoutId}", Name = "GetWorkout")]
    public async Task<ActionResult<Workout>> GetSpecificUserWorkout(int userId, int workoutId)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }
        var workout = await _userService.GetSpecificUserWorkout(userId, workoutId);
        if (workout == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Workout>(workout));
    } 

    [HttpPost]
    public async Task<ActionResult<Workout>> PostWorkoutToUser(int userId, WorkoutCreation workout)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }

        var fWorkout = _mapper.Map<Entities.Workout>(workout);

        await _userService.PostWorkoutToUser(userId, fWorkout);
        await _userService.SaveChangesAsync();

        var workoutToReturn = _mapper.Map<Models.Workout>(fWorkout);

        return CreatedAtRoute("GetWorkout", new {userId = userId, workoutId = workoutToReturn.Id}, workoutToReturn);
    }

    [HttpDelete("workoutId")]
    public async Task<ActionResult> DeleteLift(int userId, int workoutId)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }
        var workoutEntity = await _userService.GetSpecificUserWorkout(userId, workoutId);

        if (workoutEntity == null)
        {
            return NotFound();
        }
        _userService.DeleteWorkout(workoutEntity);
        await _userService.SaveChangesAsync();

        return NoContent();
    }
}