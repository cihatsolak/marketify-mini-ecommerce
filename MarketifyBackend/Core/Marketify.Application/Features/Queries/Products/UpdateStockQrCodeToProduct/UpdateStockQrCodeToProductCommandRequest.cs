namespace Marketify.Application.Features.Queries.Products.UpdateStockQrCodeToProduct
{
    public class UpdateStockQrCodeToProductCommandRequest : IRequest<UpdateStockQrCodeToProductCommandResponse>
    {
        public string ProductId { get; set; }
        public int Stock { get; set; }
    }
}
