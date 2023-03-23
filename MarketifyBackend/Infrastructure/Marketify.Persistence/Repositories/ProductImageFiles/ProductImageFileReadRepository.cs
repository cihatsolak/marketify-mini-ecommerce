namespace Marketify.Persistence.Repositories.ProductImageFiles
{
    public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
