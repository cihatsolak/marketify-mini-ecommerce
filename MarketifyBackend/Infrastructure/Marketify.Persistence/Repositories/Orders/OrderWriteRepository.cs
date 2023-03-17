namespace Marketify.Persistence.Repositories.Orders
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
