using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.BusinessLogic.Users.CreateUser
{
  public class CreateUserResponse
  {
    public string Id { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public string Message { get; set; }

  }
}
