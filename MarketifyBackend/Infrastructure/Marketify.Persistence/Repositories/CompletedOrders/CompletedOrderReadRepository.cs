namespace Marketify.Persistence.Repositories.CompletedOrders
{
    public class CompletedOrderReadRepository : ReadRepository<CompletedOrder>, ICompletedOrderReadRepository
    {
        public CompletedOrderReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }

    public class CompletedOrderWriteRepository : WriteRepository<CompletedOrder>, ICompletedOrderWriteRepository
    {
        public CompletedOrderWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
