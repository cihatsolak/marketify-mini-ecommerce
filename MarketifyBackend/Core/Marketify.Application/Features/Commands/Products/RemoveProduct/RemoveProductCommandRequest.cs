namespace Marketify.Application.Features.Commands.Products.RemoveProduct
{
    public class RemoveProductCommandRequest : IRequest<RemoveProductCommandResponse>
    {
        public string Id { get; set; }
    }
}
