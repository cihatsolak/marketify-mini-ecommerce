namespace Marketify.Persistence.Repositories.Baskets
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
