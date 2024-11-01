using MediatR;

namespace HotelConnect.BusinessLogic.Rooms.CreateRoom
{
  public class CreateRoomRequest : IRequest<CreateRoomResponse>
  {
    public int NumerOfBeds { get; set; }

    public double Price { get; set; }

    public int Capacity { get; set; }

    public int RoomType { get; set; }
  }
}
