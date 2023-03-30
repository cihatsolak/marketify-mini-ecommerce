namespace Marketify.Persistence.Repositories.Menus
{
    public class MenuWriteRepository : WriteRepository<Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
