namespace Marketify.Persistence.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
