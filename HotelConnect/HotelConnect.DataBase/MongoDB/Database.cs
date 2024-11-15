using HotelConnect.DataAbstraction.MongoDB;
using HotelConnect.Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.DataBase.MongoDB
{
  public class Database : IDatabase
  {
    public  IMongoDatabase db;
    private  MongoClient mongoClient;
    public IMongoCollection<TItem> GetCollection<TItem>(string name)
    {
      return this.db.GetCollection<TItem>(name);
    }

    public IMongoCollection<Room> GetRoomsCollection()
    {
      return this.db.GetCollection<Room>("RoomsCollection");
    }
  }
}
