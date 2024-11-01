using HotelConnect.BusinessLogic.Rooms.CreateRoom;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelConnect.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RoomsController : ControllerBase
  {

    private readonly IMediator mediator;

    public RoomsController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateRoom(CreateRoomRequest request, CancellationToken cancellationToken)
    {
      var response = await this.mediator.Send(request, cancellationToken);
      return this.Ok(response);
    }

  }
}
