using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    private readonly IExerciseService _exerciseService;
    private readonly IMapper _mapper;

    public ExerciseController(IExerciseService exerciseService, IMapper mapper) 
    {
        _exerciseService = exerciseService ?? throw new ArgumentNullException(nameof(exerciseService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Exercise>>> GetAll() 
    {
        var exerciseEntities = await _exerciseService.GetExercises();
        return Ok(_mapper.Map<IEnumerable<Exercise>>(exerciseEntities));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Exercise>> GetExerciseByID(int id)
    {
        var exercise = await _exerciseService.GetExerciseByID(id);
        if (exercise == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Exercise>(exercise));
    }
}