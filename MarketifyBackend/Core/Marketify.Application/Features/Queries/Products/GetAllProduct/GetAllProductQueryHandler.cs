namespace Marketify.Application.Features.Queries.Products.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public GetAllProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _productReadRepository.GetAll(false).Count();
            var products = _productReadRepository.GetAll(false)
                .Include(p => p.ProductImageFiles)
                .Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Stock,
                p.Price,
                p.CreatedDate,
                p.UpdatedDate,
                p.ProductImageFiles
            }).ToList();

            return new()
            {
                Products = products,
                TotalCount = totalCount
            };
        }
    }
}
