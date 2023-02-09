namespace myBase.Server;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected DbSet<TEntity> _dbSet;
    private readonly ApplicationDbContext _dbContext;
    public BaseRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public virtual async Task<List<TEntity>> GetAll() => await _dbSet.ToListAsync() ?? Activator.CreateInstance<List<TEntity>>();

    public virtual async Task<List<TEntity>> GetAll(int pageIndex, int pageSize)
    {
        List<TEntity> result = await GetAll();
        return result.GetRange((pageIndex - 1) * pageSize, pageSize);
    }

    public virtual async Task<TEntity> FindById(Guid id) => await
        _dbSet.FirstOrDefaultAsync(e => e.Id == id) ?? throw new Exception($"This {typeof(TEntity)} Not Found!");

    public virtual async Task Add(TEntity entity)
    {
        if (entity == null) throw new ArgumentNullException();
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task AddMany(List<TEntity> entities)
    {
        if(entities == null || !entities.Any()) throw new ArgumentNullException();
        await _dbSet.AddRangeAsync(entities);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task Update(TEntity entity)
    {
        if (entity == null) throw new ArgumentNullException();
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task Delete(Guid id)
    {
        TEntity entity = await FindById(id);
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task Delete(TEntity entity)
    {
        if(entity == null) throw new ArgumentNullException();
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IDbContextTransaction> GetTransaction() => await _dbContext.Database.BeginTransactionAsync();
}
