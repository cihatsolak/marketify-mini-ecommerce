namespace Marketify.Persistence.Repositories
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        readonly private MarketifyDbContext _context;

        public WriteRepository(MarketifyDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task AddAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(List<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public void Remove(TEntity entity)
        {
            Table.Remove(entity);
        }

        public void RemoveRange(List<TEntity> entities)
        {
            Table.RemoveRange(entities);
        }

        public async Task RemoveAsync(string id)
        {
            TEntity model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            Remove(model);
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }
}
