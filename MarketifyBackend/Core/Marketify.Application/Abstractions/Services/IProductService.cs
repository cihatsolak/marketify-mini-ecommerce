namespace Marketify.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task<byte[]> QrCodeToProductAsync(string productId);
        Task StockUpdateToProductAsync(string productId, int stock);
    }
}
