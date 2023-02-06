

using AspNetCoreBlazorLibrary.Models;

namespace AspNetCoreBlazorLibrary.Repository.IRepository;

public interface ISeafarerRepository
{
    public Task<Seafarer> CreateAsync(Seafarer seafarer);
    public Task<Seafarer> UpdateAsync(Seafarer seafarer);
    public Task<int> Delete(int id);
    public Task<Seafarer> Get(int id);
    public Task<IEnumerable<Seafarer>> GetAll();
}
