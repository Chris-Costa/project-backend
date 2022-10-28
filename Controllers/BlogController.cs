using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController : ControllerBase
{
    public BlogController() { }

    [HttpGet]
    public ActionResult<List<Blog>> GetAll() =>
        BlogService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Blog> Get(int id)
    {
        var blog = BlogService.Get(id);

        if(blog == null)
            return NotFound();

        return blog;
    }

    [HttpPost]
    public IActionResult Create(Blog blog)
    {            
        BlogService.Add(blog);
        return CreatedAtAction(nameof(Create), new { id = blog.Id }, blog);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Blog blog)
    {
        if (id != blog.Id)
            return BadRequest();
           
        var existingBlog = BlogService.Get(id);
        if(existingBlog is null)
            return NotFound();
   
        BlogService.Update(blog);           
   
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var blog = BlogService.Get(id);
   
        if (blog is null)
            return NotFound();
       
        BlogService.Delete(id);
   
        return NoContent();
    }
}