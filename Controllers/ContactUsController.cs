using Microsoft.AspNetCore.Mvc;
using project_backend.Models;
using project_backend.Services;
using AutoMapper;

namespace project_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactUsController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public ContactUsController(IUserService userService, IMapper mapper) 
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ContactUs>>> GetProspectiveClients() 
    {
        var contactUsEntities = await _userService.GetProspectiveClients();
        return Ok(_mapper.Map<IEnumerable<ContactUs>>(contactUsEntities));
    }

    [HttpGet("{id}", Name = "GetProspective")]
    public async Task<ActionResult<ContactUs>> GetProspectiveClientById(int id)
    {
        var client = await _userService.GetProspectiveClientById(id);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(_mapper.Map<ContactUs>(client));
    } 

    [HttpPost]
    public async Task<ActionResult<ContactUs>> CreateProspectiveClient(ContactUsCreation contactUs)
    {
        var fprospective = _mapper.Map<Entities.ContactUs>(contactUs);

        await _userService.CreateProspectiveClient(fprospective);

        await _userService.SaveChangesAsync();

        var prospectiveToReturn = _mapper.Map<Models.ContactUs>(fprospective);

        return CreatedAtRoute("GetProspective", new {Id = prospectiveToReturn.Id}, prospectiveToReturn);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProspectiveClient(int id)
    {
        if (!await _userService.ProspectiveExists(id))
        {
            return NotFound();
        }

        var prospectiveEntity = await _userService.GetProspectiveClientById(id);
        
        _userService.DeleteProspectiveClient(prospectiveEntity);

        await _userService.SaveChangesAsync();

        return NoContent();
    }
}