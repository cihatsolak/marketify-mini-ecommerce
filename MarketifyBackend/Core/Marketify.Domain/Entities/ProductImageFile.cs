namespace Marketify.Domain.Entities
{
    public class ProductImageFile : File
    {
        public bool Showcase { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
