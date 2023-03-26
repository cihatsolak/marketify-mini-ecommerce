namespace Marketify.Persistence.Repositories.Baskets
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
