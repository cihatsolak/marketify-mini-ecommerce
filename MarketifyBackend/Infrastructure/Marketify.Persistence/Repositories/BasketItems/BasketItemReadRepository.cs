namespace Marketify.Persistence.Repositories.BasketItems
{
    public class BasketItemReadRepository : ReadRepository<BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
