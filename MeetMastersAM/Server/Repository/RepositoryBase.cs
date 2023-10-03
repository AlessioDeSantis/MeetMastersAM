using MeetMastersAM.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ApplicationDbContext _dbcontext;
        public RepositoryBase(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

        public async Task Create(T entity)
        {
            await _dbcontext.Set<T>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbcontext.Update(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbcontext.Set<T>().FindAsync(id);
        }

        public async Task Delete(int id)
        {
            var result = await GetById(id);
            if (result != null) 
            {
                _dbcontext.Set<T>().Remove(result);
                await _dbcontext.SaveChangesAsync();
            }
        }

    }
}
