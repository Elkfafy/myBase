namespace myBase.Server;

[Route("api/[controller]")]
[ApiController]
public class BaseController<TEntity> : ControllerBase where TEntity : BaseEntity
{
    private readonly IBaseUnitOfWork<TEntity> _unitOfWork;
    public BaseController(IBaseUnitOfWork<TEntity> unitOfWork) { _unitOfWork = unitOfWork; }
    
    [HttpGet]
    public virtual async Task<List<TEntity>> Get() => await _unitOfWork.GetAll();
    [HttpGet]
    public virtual async Task<List<TEntity>> Get(int pageIndex, int pageSize) => await _unitOfWork.GetAll(pageIndex, pageSize);
    [HttpGet]
    public virtual async Task<TEntity> Get(Guid id) => await _unitOfWork.FindById(id);

    [HttpPut]
    public virtual async Task Put(TEntity entity) { await _unitOfWork.Update(entity); }

    [HttpPost]
    public virtual async Task Post(TEntity entity) { await _unitOfWork.Add(entity); }
    [HttpPost]
    public virtual async Task Post(List<TEntity> entity) { await _unitOfWork.AddMany(entity); }

    [HttpDelete]
    public virtual async Task Delete(TEntity entity) { await _unitOfWork.Delete(entity); }
    [HttpDelete]
    public virtual async Task Delete(Guid id) { await _unitOfWork.Delete(id); }
}
