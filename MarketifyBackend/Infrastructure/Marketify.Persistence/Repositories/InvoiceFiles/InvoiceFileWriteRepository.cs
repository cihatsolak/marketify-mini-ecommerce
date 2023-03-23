namespace Marketify.Persistence.Repositories.InvoiceFiles
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
