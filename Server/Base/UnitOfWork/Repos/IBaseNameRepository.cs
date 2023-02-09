namespace myBase.Server;

public interface IBaseNameRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseName
{
    Task<List<TEntity>> FindByName(string name);
}
