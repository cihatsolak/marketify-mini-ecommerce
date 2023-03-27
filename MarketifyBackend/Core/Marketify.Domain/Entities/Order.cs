namespace Marketify.Domain
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }

        public Basket Basket { get; set; }
    }
}
