namespace HotelConnect.DataAbstraction
{
  public interface IRepositorie<T>
  {
    public Task<string> InsertAsync(T entity, CancellationToken cancellationToken);

    public Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);


    public Task<bool> PatchAsync(T entity, CancellationToken cancellationToken);


    public Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken);

    public Task<List<T>> GetAllAsync(CancellationToken cancellationToken);

    public Task<T> GetByIdAsync(string id, CancellationToken cancellationToken);
  }
}
