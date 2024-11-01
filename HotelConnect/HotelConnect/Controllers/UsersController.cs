using HotelConnect.BusinessLogic.Users.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelConnect.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private IMediator mediator;

    public UsersController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserRequest request, CancellationToken cancellationToken)
    {
      var response = await this.mediator.Send(request, cancellationToken);
      return this.Ok("User created unsuccessfully");
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
      return this.Ok("Users list");
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(string id)
    {
      return this.Ok($"User with id {id} found");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
      return this.Ok($"User with id {id} deleted");
    }

    //patch put
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(string id)
    {
      return this.Ok($"User with id {id} updated");

    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchUser(string id)
    {
      return this.Ok($"Updated user with id {id}");
    }
  }
}
