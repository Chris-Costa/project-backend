using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;
    private readonly IMapper _mapper;

    public BlogController(IBlogService blogService, IMapper mapper) 
    {
        _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs() 
    {
        var blogEntities = await _blogService.GetBlogs();
        return Ok(_mapper.Map<IEnumerable<Blog>>(blogEntities));
    }

    [HttpGet("{id}", Name = "GetBlog")]
    public async Task<ActionResult<Blog>> GetBlogByID(int id)
    {
        var blog = await _blogService.GetBlogByID(id);
        if (blog == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Blog>(blog));
    } 

    [HttpPost]
    public async Task<ActionResult<Blog>> CreateBlogPost(BlogCreation post)
    {
        var fblog = _mapper.Map<Entities.Blog>(post);

        await _blogService.CreateBlogPost(fblog);

        await _blogService.SaveChangesAsync();

        var postToReturn = _mapper.Map<Models.Blog>(fblog);

        return CreatedAtRoute("GetBlog", new {Id = postToReturn.Id}, postToReturn);
    }

    //not sure i really wnat this option.  Other users will have comments wiped away
    [HttpDelete("{blogId}")]
    public async Task<ActionResult> DeleteBlog(int blogId)
    {
        if (!await _blogService.BlogExists(blogId))
        {
            return NotFound();
        }

        var blogEntity = await _blogService.GetBlogByID(blogId);

        if (blogEntity == null)
        {
            return NotFound();
        }

        _blogService.DeleteBlog(blogEntity);
        await _blogService.SaveChangesAsync();

        return NoContent();
    }
}