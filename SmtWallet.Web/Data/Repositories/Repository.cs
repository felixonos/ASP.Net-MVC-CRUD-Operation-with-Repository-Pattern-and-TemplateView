using Microsoft.EntityFrameworkCore;
using SmtWallet.Web.Data.Entities;
using SmtWallet.Web.Data.Repositories.Interfaces;

namespace SmtWallet.Web.Data.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(TKey id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            _dbContext.Set<TEntity>().Remove(entity!);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> Get(string filter)
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<TEntity> Get(TKey id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            return entity!;
        }

        public async Task Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}