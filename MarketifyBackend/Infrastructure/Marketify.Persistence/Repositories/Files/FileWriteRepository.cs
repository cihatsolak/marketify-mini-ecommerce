namespace Marketify.Persistence.Repositories.Files
{
    public class FileWriteRepository : WriteRepository<File>, IFileWriteRepository
    {
        public FileWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
