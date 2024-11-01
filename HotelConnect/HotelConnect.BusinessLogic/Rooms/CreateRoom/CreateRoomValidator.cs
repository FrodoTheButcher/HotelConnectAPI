using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.BusinessLogic.Rooms.CreateRoom
{
  public class CreateRoomValidator : AbstractValidator<CreateRoomRequest>
  {
    public CreateRoomValidator() {

      this.RuleFor(request => request.Price).GreaterThan(0.0);
      this.RuleFor(request => request.NumerOfBeds).GreaterThan(0);
      this.RuleFor(request => request.Capacity).GreaterThan(0);
      this.RuleFor(request => request.RoomType).NotEmpty();

    }
  }
}
