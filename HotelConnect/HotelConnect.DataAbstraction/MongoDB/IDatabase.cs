using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.DataAbstraction.MongoDB
{
  public interface IDatabase
  {
    IMongoCollection<TItem> GetCollection<TItem>(string name);
  }
}
