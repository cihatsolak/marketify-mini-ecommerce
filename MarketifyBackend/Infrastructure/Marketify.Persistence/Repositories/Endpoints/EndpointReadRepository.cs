namespace Marketify.Persistence.Repositories.Endpoints
{
    public class EndpointReadRepository : ReadRepository<Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
