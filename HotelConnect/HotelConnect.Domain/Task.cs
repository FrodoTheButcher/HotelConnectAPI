using MongoDB.Bson;

namespace HotelConnect.Domain
{
  public class Task : Room
  {
    public Task()
      :base()
    {
    
    }
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public EStatus Status { get; set; }

    public string? UserId { get; set; }  = null;
  }

  public enum EStatus
  {
    Assigned,
    InProgress,
    Cancelled,
    Done
  }
}
