namespace Marketify.Persistence.Repositories.Menus
{
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        public MenuReadRepository(MarketifyDbContext context) : base(context)
        {
        }
    }
}
