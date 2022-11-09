using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private readonly IBlogService _blogService;
    private readonly IMapper _mapper;

    public CommentController(IBlogService blogService, IMapper mapper) 
    {
        _blogService = blogService ?? throw new ArgumentNullException(nameof(blogService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Comment>>> GetAllBlogsComments(int blogId)
    {
        if (!await _blogService.BlogExists(blogId))
        {
            return NotFound();
        }
        var commentsForBlog = await _blogService.GetAllBlogsComments(blogId);

        return Ok(_mapper.Map<IEnumerable<Comment>>(commentsForBlog));
    }

    [HttpGet("{commentid}", Name = "GetComment")]
    public async Task<ActionResult<Comment>> GetSpecificBlogComment(int blogId, int commentId)
    {
        if (!await _blogService.BlogExists(blogId))
        {
            return NotFound();
        }
        var comment = await _blogService.GetSpecificBlogComment(blogId, commentId);
        if (comment == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<Comment>(comment));
    }

    [HttpPost]
    public async Task<ActionResult<Comment>> CreateCommentForBlogPost(int blogId, CommentCreation comment)
    {
        if (!await _blogService.BlogExists(blogId))
        {
            return NotFound();
        }

        var fComment = _mapper.Map<Entities.Comment>(comment);

        await _blogService.PostCommentToBlogPost(blogId, fComment);

        await _blogService.SaveChangesAsync();

        var commentToReturn = _mapper.Map<Models.Comment>(fComment);

        return CreatedAtRoute("GetComment", new {blogId = blogId, commentId = commentToReturn.Id}, commentToReturn);
    }
}