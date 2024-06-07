using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BusinessObjects
{
    public class MyStoreContext : DbContext
    {
        private readonly string connectionString = "Data Source=localhost,1433;Initial Catalog=MyStore;User ID=sa;Password=123456;TrustServerCertificate=True";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<AccountMember> accountMembers { get; set; }
        // Các DbSet khác cho các thực thể khác...

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
