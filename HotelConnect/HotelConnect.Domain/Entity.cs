using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.Domain
{
  public class Entity
  {
    public string Id { get; set; }

    public Entity()
    {
      this.Id = ObjectId.GenerateNewId().ToString();
    }
  }
}
