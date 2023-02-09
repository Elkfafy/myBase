namespace myBase.Server;

public interface IBaseUnitOfWork<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAll();
    Task<List<TEntity>> GetAll(int pageIndex, int pageSize);
    Task<TEntity> FindById(Guid id);

    Task Add(TEntity entity);
    Task AddMany(List<TEntity> entities);

    Task Update(TEntity entity);

    Task Delete(Guid id);
    Task Delete(TEntity entity);
}
