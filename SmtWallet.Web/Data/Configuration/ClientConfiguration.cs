using Microsoft.EntityFrameworkCore;
using SmtWallet.Web.Data.Entities;

namespace SmtWallet.Web.Data.Configuration
{
    public class ClientConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("first_name");
            modelBuilder.Entity<Client>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Client>().Property(c => c.PhoneNumber).HasMaxLength(50);
            modelBuilder.Entity<Client>().Property(c => c.Email).HasMaxLength(256);

            modelBuilder.Entity<Client>().HasIndex(c => c.PhoneNumber).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(c => c.Email).IsUnique();    
            return modelBuilder;
        }
    }
}
