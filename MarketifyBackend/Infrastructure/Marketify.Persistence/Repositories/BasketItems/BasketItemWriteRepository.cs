namespace Marketify.Persistence.Repositories.BasketItems
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
