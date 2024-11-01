using HotelConnect.DataAbstraction;
using HotelConnect.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConnect.Repositories.UserRepositories
{
  public class UserRepositories : IUserRepositorie
  {
    public Task<bool> DeleteAsync(User entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<List<User>> GetAllAsync(CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(string id, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<string> InsertAsync(User entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<bool> PatchAsync(User entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(User entity, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}

