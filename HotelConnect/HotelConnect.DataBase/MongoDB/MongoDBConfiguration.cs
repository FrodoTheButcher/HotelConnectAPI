using HotelConnect.DataAbstraction.MongoDB;

namespace HotelConnect.DataBase.MongoDB
{
  public class MongoDBConfiguration : IDatabaseConfiguration
  {
    public string ConnectionURI { get; set; }
    public string DatabaseName { get; set; }
  }
}
