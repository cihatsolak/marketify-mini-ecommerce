using Marketify.Domain.Entities;

namespace Marketify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(
            IProductWriteRepository productWriteRepository, 
            IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _productWriteRepository.AddAsync(new Product
            {
                Name = "Test",
                Price = 1,
                Stock = 2,
                CreatedDate = DateTime.UtcNow
            });

            await _productWriteRepository.SaveAsync();

            var products = _productReadRepository.GetAll(false);
            return Ok(products);
        }
    }
}
