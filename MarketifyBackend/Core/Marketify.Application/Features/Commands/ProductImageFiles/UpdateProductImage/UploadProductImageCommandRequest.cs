namespace Marketify.Application.Features.Commands.ProductImageFiles.UpdateProductImage
{
    public class UploadProductImageCommandRequest : IRequest<UploadProductImageCommandResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
