using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepositories;


namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        public async Task DeleteAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            entities.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
         
            var objEntity = await entities.FindAsync(id);
            if (objEntity != null)
            {
                return objEntity!;
            }
            return null;
        }

        public async Task InsertAsync(T entity)
        {
            if(entity == null) throw new ArgumentNullException(nameof(entity));
            await entities.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            entities.Update(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
