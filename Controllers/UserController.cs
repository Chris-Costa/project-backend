using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController() { }

    [HttpGet]
    public ActionResult<List<User>> GetAll() =>
        UserService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var user = UserService.Get(id);

        if(user == null)
            return NotFound();

        return user;
    }

    [HttpPost]
    public IActionResult Create(User user)
    {            
        UserService.Add(user);
        return CreatedAtAction(nameof(Create), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, User user)
    {
        if (id != user.Id)
            return BadRequest();
           
        var existingUser = UserService.Get(id);
        if(existingUser is null)
            return NotFound();
   
        UserService.Update(user);           
   
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = UserService.Get(id);
   
        if (user is null)
            return NotFound();
       
        UserService.Delete(id);
   
        return NoContent();
    }
    /*
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    */
}