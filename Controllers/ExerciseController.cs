using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    public ExerciseController() { }

    [HttpGet]
    public ActionResult<List<Exercise>> GetAll() =>
        ExerciseService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Exercise> Get(int id)
    {
        var exercise = ExerciseService.Get(id);

        if(exercise == null)
            return NotFound();

        return exercise;
    }

    [HttpPost]
    public IActionResult Create(Exercise exercise)
    {            
        ExerciseService.Add(exercise);
        return CreatedAtAction(nameof(Create), new { id = exercise.Id }, exercise);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Exercise exercise)
    {
        if (id != exercise.Id)
            return BadRequest();
           
        var existingExercise = ExerciseService.Get(id);
        if(existingExercise is null)
            return NotFound();
   
        ExerciseService.Update(exercise);           
   
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var exercise = ExerciseService.Get(id);
   
        if (exercise is null)
            return NotFound();
       
        ExerciseService.Delete(id);
   
        return NoContent();
    }
}