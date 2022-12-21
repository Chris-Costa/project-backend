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
    public async Task<ActionResult<IEnumerable<Lift>>> GetAll() 
    {
        var liftEntities = await _userService.GetLifts();
        return Ok(_mapper.Map<IEnumerable<Lift>>(liftEntities));
    }
    //not sure if this is useful
    [HttpGet("{id}")]
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
    public async Task<ActionResult<Lift>> GetSpecificWorkoutLift(int liftId)
    {
        var lift = await _userService.GetSpecificWorkoutLift(liftId);
        if (lift == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Lift>(lift));
    } 

    [HttpPost]
    public async Task<ActionResult<Lift>> AddLift(int workoutId, LiftCreation lift)
    {
        if (!await _userService.WorkoutExists(workoutId))
        {
            return NotFound();
        }

        var fLift = _mapper.Map<Entities.Lift>(lift);

        await _userService.PostLiftToWorkout(workoutId, fLift);
        await _userService.SaveChangesAsync();

        var liftToReturn = _mapper.Map<Models.Lift>(fLift);

        return CreatedAtRoute("GetLift", new {workoutId = workoutId, liftId = liftToReturn.Id}, liftToReturn);
    }

    [HttpDelete("liftId")]
    public async Task<ActionResult> DeleteLift(int liftId)
    {
        var liftEntity = await _userService.GetLiftByID(liftId);

        if (liftEntity == null)
        {
            return NotFound();
        }
        _userService.DeleteLift(liftEntity);
        await _userService.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{liftId}")]
    public async Task<ActionResult> UpdateUser(int liftId, LiftUpdate liftUpdate)
    {
        if (!await _userService.LiftExists(liftId))
        {
            return NotFound();
        }

        var liftEntity = await _userService.GetLiftByID(liftId);

        _mapper.Map(liftUpdate, liftEntity);

        await _userService.SaveChangesAsync();

        return NoContent();
    }
}