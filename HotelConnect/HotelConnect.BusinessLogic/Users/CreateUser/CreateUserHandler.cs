using HotelConnect.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.BusinessLogic.Users.CreateUser
{
  public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
  {
    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
      User user = new User();
      user.Username = request.Username;
      user.Age = request.Age;
      user.Email = request.Email;
      user.Password = request.Password;
      user.Id = Guid.NewGuid().ToString();

      //adaugam in database

      return new CreateUserResponse
      {
        Message = "Success",
        Id = user.Id,
        StatusCode = System.Net.HttpStatusCode.Created,
      };
    }
  }
}
