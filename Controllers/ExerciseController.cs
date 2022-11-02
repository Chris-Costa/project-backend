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

    public ExerciseController(IExerciseService exerciseService /*IMapper mapper*/) 
    {
        _exerciseService = exerciseService ?? throw new ArgumentNullException(nameof(exerciseService));
        /*_mapper = mapper;*/
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Exercise>>> GetAll() 
    {
        var exerciseEntities = await _exerciseService.GetExercises();
        var results = new List<Exercise>();
        
        foreach(var exerciseEntity in exerciseEntities)
        {
            results.Add(new Exercise 
            {
                Id = exerciseEntity.Id,
                Name = exerciseEntity.Name,
                MuscleGroup = exerciseEntity.MuscleGroup,
                Description = exerciseEntity.Description,
                RepRange = exerciseEntity.RepRange,
                Difficulty = exerciseEntity.Difficulty,
                ImageURL = exerciseEntity.ImageURL,
                VideoURL = exerciseEntity.VideoURL
            });
        }
        return Ok(results);
        //ExerciseService.GetAll();
    }
/*
    [HttpGet("{id}")]
    public ActionResult<Exercise> Get(int id)
    {
        var exercise = ExerciseService.Get(id);

        if(exercise == null)
            return NotFound();

        return exercise;
    }
    */
}