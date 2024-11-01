using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.DataAbstraction.MongoDB
{
  public interface IDatabaseConfiguration
  {
     string ConnectionURI { get; set; }

     string DatabaseName { get; set; }
  }
}
