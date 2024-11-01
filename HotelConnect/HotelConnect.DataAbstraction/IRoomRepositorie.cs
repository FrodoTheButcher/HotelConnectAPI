using HotelConnect.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.DataAbstraction
{
  public interface IRoomRepositorie : IRepositorie<Room>
  {
    public Task<Room> GetRoomByFloor(int floor, CancellationToken token);
  }
}
