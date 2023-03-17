namespace Marketify.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);
        void Update(TEntity entity);
        Task RemoveAsync(string id);
        void Remove(TEntity entity);
        void RemoveRange(List<TEntity> entities);
        Task<int> SaveAsync();
    }
}
