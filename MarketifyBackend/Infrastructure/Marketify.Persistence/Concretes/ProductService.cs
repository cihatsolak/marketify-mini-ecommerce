namespace Marketify.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() 
                {
                    Id = Guid.NewGuid(),
                    Name = "Test",
                    Price = 115,
                    Stock = 2,
                    CreatedDate = DateTime.Now
                } 
            };
        }
    }
}
