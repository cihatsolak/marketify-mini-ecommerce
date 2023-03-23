namespace Marketify.Persistence.Repositories.InvoiceFiles
{
    public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
