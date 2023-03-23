namespace Marketify.Persistence.Repositories.ProductImageFiles
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
