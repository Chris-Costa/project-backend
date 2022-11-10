using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class LiftController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IExerciseService _exerciseService;
    private readonly IMapper _mapper;

    public LiftController(IUserService userService, IExerciseService exerciseService, IMapper mapper) 
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _exerciseService = exerciseService ?? throw new ArgumentNullException(nameof(exerciseService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lift>>> GetAllLiftsOfWorkout(int workoutId)
    {
        if (!await _userService.WorkoutExists(workoutId))
        {
            return NotFound();
        }
        var workoutsLifts = await _userService.GetAllLiftsOfWorkout(workoutId);

        return Ok(_mapper.Map<IEnumerable<Lift>>(workoutsLifts));
    }
    
    [HttpGet("{liftId}", Name = "GetLift")]
    public async Task<ActionResult<Lift>> GetSpecificWorkoutLift(int workoutId, int liftId)
    {
        if (!await _userService.WorkoutExists(workoutId))
        {
            return NotFound();
        }
        var lift = await _userService.GetSpecificWorkoutLift(workoutId, liftId);
        if (lift == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Lift>(lift));
    } 

    [HttpPost]
    public async Task<ActionResult<Lift>> PostLiftToWorkout(int workoutId, int exerciseId, LiftCreation lift)
    {
        if (!await _userService.WorkoutExists(workoutId))
        {
            return NotFound();
        }

        if(!await _exerciseService.ExerciseExists(exerciseId))
        {
            return NotFound();
        }

        var fLift = _mapper.Map<Entities.Lift>(lift);

        await _userService.PostLiftToWorkout(workoutId, exerciseId, fLift);
        await _userService.SaveChangesAsync();

        var liftToReturn = _mapper.Map<Models.Lift>(fLift);

        return CreatedAtRoute("GetLift", new {workoutId = workoutId, exerciseId = exerciseId, liftId = liftToReturn.Id}, liftToReturn);
    }

    [HttpDelete("liftId")]
    public async Task<ActionResult> DeleteLift(int workoutId, int liftId)
    {
        if (!await _userService.WorkoutExists(workoutId))
        {
            return NotFound();
        }
        var liftEntity = await _userService.GetSpecificWorkoutLift(workoutId, liftId);

        if (liftEntity == null)
        {
            return NotFound();
        }
        _userService.DeleteLift(liftEntity);
        await _userService.SaveChangesAsync();

        return NoContent();
    }
}