namespace myBase.Server;

public interface IBaseNameUnitOfWork<TEntity> : IBaseUnitOfWork<TEntity> where TEntity : BaseName
{
    Task<List<TEntity>> FindByName(string name);
}
