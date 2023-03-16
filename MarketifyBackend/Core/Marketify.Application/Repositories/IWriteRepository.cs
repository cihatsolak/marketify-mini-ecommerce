namespace Marketify.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddRangeAsync(List<TEntity> entities);
        bool Update(TEntity model);
        Task<bool> RemoveAsync(string id);
        bool Remove(TEntity entity);
        bool RemoveRange(List<TEntity> entities);
        Task<int> SaveAsync();
    }
}
