using SmtWallet.Web.Data.Entities;

namespace SmtWallet.Web.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        Task<IEnumerable<TEntity>> Get(string filter);
        Task<TEntity> Get(TKey id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TKey id);
        
    }
}
