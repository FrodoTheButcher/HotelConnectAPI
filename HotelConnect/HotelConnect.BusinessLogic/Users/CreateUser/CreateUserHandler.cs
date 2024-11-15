using HotelConnect.DataAbstraction;
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
    private readonly IUserRepositorie userRepositorie;

    public CreateUserHandler(IUserRepositorie userRepositorie)
    {
      this.userRepositorie = userRepositorie;
    }
    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
      User user = new User();

      user.Email = request.Email;
      user.Password = request.Password;
      user.Id = Guid.NewGuid().ToString();

      await this.userRepositorie.InsertAsync(user, cancellationToken);

      return new CreateUserResponse
      {
        Message = "Success",
        Id = user.Id,
        StatusCode = System.Net.HttpStatusCode.Created,
      };
    }
  }
}
