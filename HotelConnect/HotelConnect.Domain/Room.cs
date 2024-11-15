using MongoDB.Bson;

namespace HotelConnect.Domain
{
  public class Room : Entity
  {
    public Room()
      :base()
    {
    }
    public string Id { get; set; }

    public int NumerOfBeds { get; set; }

    public double Price { get; set; }

    public int RoomStatus { get; set; }

    public int Capacity { get; set; }

    public int RoomType {  get; set; }
  }
}
