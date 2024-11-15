using HotelConnect.Domain.Enums;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelConnect.Domain
{
  public class User : Entity
  {
    public User() : base()
    {
    }
    public string Id { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public EUserRole UserRole { get; set; }

    public List<EUserRole> Roles { get; set; }

    public string AzureId { get; set; }

    public List<Task> Tasks { get; set; }

  }

}
