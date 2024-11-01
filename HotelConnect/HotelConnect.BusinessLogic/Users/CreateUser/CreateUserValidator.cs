using FluentValidation;

namespace HotelConnect.BusinessLogic.Users.CreateUser
{
  public class CreateUserValidator : AbstractValidator<CreateUserRequest>
  {
    public CreateUserValidator() {

      this.RuleFor(request => request.Age).GreaterThanOrEqualTo(18);
      this.RuleFor(request => request.Username).NotEmpty().MaximumLength(30);
      this.RuleFor(request => request.WorkExperience).GreaterThanOrEqualTo(1);
      this.RuleFor(request => request.Password).NotEmpty().MinimumLength(10);
      this.RuleFor(request => request.Email).NotEmpty().MaximumLength(30);
    }
  }
}
