namespace myBase.Server;

public class BaseNameRepository<TEntity> : BaseRepository<TEntity>, IBaseNameRepository<TEntity>
    where TEntity : BaseName
{
    public BaseNameRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    public virtual async Task<List<TEntity>> FindByName(string name) => await _dbSet.Where(e => e.Name.Contains(name)).ToListAsync();
}
