using HotelConnect.DataAbstraction;
using HotelConnect.DataAbstraction.MongoDB;
using HotelConnect.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.Repositories.RoomRepositories
{
  public class RoomRepositories : IRoomRepositorie
  {
    private readonly IDatabase _database;

    public RoomRepositories(IDatabase database)
    {
      _database = database;
    }

    public Task<bool> DeleteAsync(Room entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<List<Room>> GetAllAsync(CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<Room> GetByIdAsync(string id, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<Room> GetRoomByFloor(int floor, CancellationToken token)
    {
      throw new NotImplementedException();
    }

    public Task<string> InsertAsync(Room entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<bool> PatchAsync(Room entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Room entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
