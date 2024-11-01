using HotelConnect.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.BusinessLogic.Rooms.CreateRoom
{
  public class CreateRoomHandler : IRequestHandler<CreateRoomRequest, CreateRoomResponse>
  {
    public async Task<CreateRoomResponse> Handle(CreateRoomRequest request, CancellationToken cancellationToken)
    {
      Room room = new Room();
      room.NumerOfBeds = request.NumerOfBeds;
      room.Capacity = request.Capacity;
      room.Price = request.Price;
      room.RoomStatus = 0; // free

      //insert to database

      return new CreateRoomResponse
      {
        Id = "",
        Message = "Room created successfully",
        StatusCode = 200
      };
    }
  }
}
