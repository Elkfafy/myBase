namespace myBase.Server;

public class BaseUnitOfWork<TEntity> : IBaseUnitOfWork<TEntity> where TEntity : BaseEntity
{
    private readonly IBaseRepository<TEntity> _repository;
    public BaseUnitOfWork(IBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public virtual async Task Add(TEntity entity)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.Add(entity);
            await transaction.CommitAsync();
        } catch(Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(ex.ToString());
        }
    }
    public virtual async Task AddMany(List<TEntity> entities)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.AddMany(entities);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(ex.ToString());
        }
    }

    public virtual async Task Delete(Guid id)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.Delete(id);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(ex.ToString());
        }
    }
    public virtual async Task Delete(TEntity entity)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.Delete(entity);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(ex.ToString());
        }
    }

    public virtual async Task<TEntity> FindById(Guid id)
    {
        try
        {
            return await _repository.FindById(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return null;
        }
    }
    public virtual async Task<List<TEntity>> GetAll() => await _repository.GetAll();
    public virtual async Task<List<TEntity>> GetAll(int pageIndex, int pageSize) => await _repository.GetAll(pageIndex, pageSize);

    public virtual async Task Update(TEntity entity)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.Update(entity);
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            Console.WriteLine(ex.ToString());
        }
    }
}
