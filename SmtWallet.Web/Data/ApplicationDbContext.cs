using Microsoft.EntityFrameworkCore;
using SmtWallet.Web.Data.Configuration;
using SmtWallet.Web.Data.Entities;

namespace SmtWallet.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }

        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ClientConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
