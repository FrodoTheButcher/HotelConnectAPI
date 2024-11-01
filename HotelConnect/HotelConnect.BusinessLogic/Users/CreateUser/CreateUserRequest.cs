using MediatR;

namespace HotelConnect.BusinessLogic.Users.CreateUser
{
  public class CreateUserRequest : IRequest<CreateUserResponse>
  {
    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int Age { get; set; }

    public int WorkExperience { get; set; }
  }
}
