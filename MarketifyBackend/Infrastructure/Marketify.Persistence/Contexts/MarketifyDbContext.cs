namespace Marketify.Persistence.Contexts
{
    public class MarketifyDbContext : DbContext
    {
        public MarketifyDbContext(DbContextOptions<MarketifyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
