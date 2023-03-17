namespace Marketify.Persistence.Repositories.Customers
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
