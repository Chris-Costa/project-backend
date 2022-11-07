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

    [HttpGet("{id}")]
    public async Task<ActionResult<Blog>> GetBlogByID(int id)
    {
        var blog = await _blogService.GetBlogByID(id);
        if (blog == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Blog>(blog));
    } 
/*
    [HttpPost]
    public async Task<ActionResult<Blog>> CreateBlogPost(Blog post)
    {
        var blog = _mapper.Map<Entities.Blog>(post);
    }
    */
}