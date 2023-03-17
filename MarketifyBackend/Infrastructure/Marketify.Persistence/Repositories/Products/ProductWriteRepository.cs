namespace Marketify.Persistence.Repositories.Products
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
