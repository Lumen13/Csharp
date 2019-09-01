using Microsoft.EntityFrameworkCore;
using TestSevPhone.Data.DataBaseModel;

namespace TestSevPhone.Data.EF
{
    public class EFContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
