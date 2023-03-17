namespace Marketify.Persistence.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
