namespace Marketify.Application.Features.Queries.Orders
{
    public class GetAllOrdersQueryResponse
    {
        public int TotalOrderCount { get; set; }
        public object Orders { get; set; }
    }
}
