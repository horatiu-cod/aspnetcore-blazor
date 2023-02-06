using AspNetCoreBlazorLibrary.DataAccess;
using AspNetCoreBlazorLibrary.Models;
using AspNetCoreBlazorLibrary.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBlazorLibrary.Repository;

public class SeafarerRepository : ISeafarerRepository
{
    private readonly ApplicationDbContext _db;

    public SeafarerRepository(ApplicationDbContext db)
    {
       _db = db;
    }

    public async Task<Seafarer> CreateAsync(Seafarer seafarer)
    {
        await _db.Seafarers.AddAsync(seafarer);
        await _db.SaveChangesAsync();
        return seafarer;
    }
    public async Task<Seafarer> UpdateAsync(Seafarer seafarer)
    {
        var sfObj = await _db.Seafarers.FirstOrDefaultAsync(s => s.SeafarerId == seafarer.SeafarerId);
        if (sfObj != null)
        {
            _db.Seafarers.Update(sfObj);
            await _db.SaveChangesAsync();
            return sfObj;
        }
        return seafarer;
    }
    public async Task<int> Delete(int id)
    {
        var seafarer = await  _db.Seafarers.FirstOrDefaultAsync(s => s.SeafarerId == id);
        if (seafarer!=null)
        {
            _db.Seafarers.Remove(seafarer);
            return await _db.SaveChangesAsync();
        }
        return 0;
    }

    public async Task<IEnumerable<Seafarer>> GetAll()
    {
        var seafarers =  _db.Seafarers;
        return seafarers;
    }

    public async Task<Seafarer> Get(int id)
    {
        var seafarer =  await _db.Seafarers.FirstOrDefaultAsync(s => s.SeafarerId == id);
        if (seafarer != null)
        {
            return seafarer;
        }
        return new Seafarer();
    } 

   
}
