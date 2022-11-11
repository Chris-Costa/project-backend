using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
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

    [HttpGet("{id}", Name = "GetUser")]
    public async Task<ActionResult<User>> GetUserByID(int id)
    {
        var user = await _userService.GetUserByID(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<User>(user));
    } 

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(UserCreation user)
    {
        var fUser = _mapper.Map<Entities.User>(user);

        await _userService.CreateUser(fUser);

        await _userService.SaveChangesAsync();

        var userToReturn = _mapper.Map<Models.User>(fUser);

        return CreatedAtRoute("GetUser", new {Id = userToReturn.Id}, userToReturn);
    }

    [HttpDelete("{userId}")]
    public async Task<ActionResult> DeleteUser(int userId)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }

        var userEntity = await _userService.GetUserByID(userId);

        if (userEntity == null)
        {
            return NotFound();
        }

        _userService.DeleteUser(userEntity);

        await _userService.SaveChangesAsync();

        return NoContent();
    }

    [HttpPut("{userId}")]
    public async Task<ActionResult> UpdateUser(int userId, UserUpdate userUpdate)
    {
        if (!await _userService.UserExists(userId))
        {
            return NotFound();
        }

        var userEntity = await _userService.GetUserByID(userId);

        _mapper.Map(userUpdate, userEntity);

        await _userService.SaveChangesAsync();

        return NoContent();
    }
}