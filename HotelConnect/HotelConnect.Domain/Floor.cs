using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.Domain
{
  
  public class Floor : Entity
  {
    public Floor() 
    :base()
    {
    }
    public int Number { get; set; }


    public List<Room> Rooms { get; set; }
  }
}
