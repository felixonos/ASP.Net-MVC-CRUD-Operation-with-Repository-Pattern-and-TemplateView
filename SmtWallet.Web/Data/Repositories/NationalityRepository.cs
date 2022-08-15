using Microsoft.EntityFrameworkCore;
using SmtWallet.Web.Data.Entities;
using SmtWallet.Web.Data.Repositories.Interfaces;

namespace SmtWallet.Web.Data.Repositories
{
    //public class ClientRepository : IClientRepository
    public class NationalityRepository : Repository<Nationality, Guid>
    {
        public NationalityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

    //    private ApplicationDbContext _dbContext;

    //    public ClientRepository(ApplicationDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }
    //    public async Task<Guid> Add(Client client)
    //    {
    //        _dbContext.Clients.Add(client);
    //        await _dbContext.SaveChangesAsync();
    //        return client.Id;
    //    }

    //    public async Task Delete(Guid id)
    //    {
    //        var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
    //        _dbContext.Clients.Remove(client!);
    //        await _dbContext.SaveChangesAsync();
    //    }

    //    public async Task<IEnumerable<Client>> Get(string filter)
    //    {
    //        var clients = await _dbContext.Clients.ToListAsync();
    //        return clients;
    //    }

    //    public async Task<Client> Get(Guid id)
    //    {
    //        var client = await _dbContext.Clients.FirstOrDefaultAsync(c=> c.Id == id);
    //        return client!;
    //    }

    //    public async Task Update(Client client)
    //    {
    //        _dbContext.Clients.Update(client);
    //        await _dbContext.SaveChangesAsync();
    //    }
    }
}
