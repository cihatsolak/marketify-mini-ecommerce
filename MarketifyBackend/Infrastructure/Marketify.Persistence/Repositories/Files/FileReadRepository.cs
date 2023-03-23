namespace Marketify.Persistence.Repositories.Files
{
    public class FileReadRepository : ReadRepository<File>, IFileReadRepository
    {
        public FileReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
