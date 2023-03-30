namespace Marketify.Persistence.Repositories.Endpoints
{
    public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
