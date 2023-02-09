namespace myBase.Server;

public class BaseNameUnitOfWork<TEntity> : BaseUnitOfWork<TEntity>, IBaseNameUnitOfWork<TEntity>
    where TEntity : BaseName
{
    private readonly IBaseNameRepository<TEntity> _repository;
    public BaseNameUnitOfWork(IBaseNameRepository<TEntity> repository) : base(repository) { _repository = repository; }

    public virtual async Task<List<TEntity>> FindByName(string name)
    {
        return await _repository.FindByName(name);
    }
}
