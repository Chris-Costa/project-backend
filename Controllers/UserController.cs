using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    /*
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper) 
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers() 
    {
        var userEntities = await _userService.GetUsers();
        return Ok(_mapper.Map<IEnumerable<User>>(userEntities));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserByID(int id)
    {
        var user = await _userService.GetUserByID(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<User>(user));
    } 
    */
}