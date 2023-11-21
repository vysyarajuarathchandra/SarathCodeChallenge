using Microsoft.EntityFrameworkCore;
using SarathCodeChallenge.Entites;

namespace SarathCodeChallenge.Database
{
    public class MyContext :DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = KOMAL; Initial Catalog=SarathCode;User Id=Ecom;Password=1234;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
