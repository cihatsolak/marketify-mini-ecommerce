namespace Marketify.Persistence.Repositories.Orders
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
