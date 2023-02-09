namespace myBase.Server;

[Route("api/[controller]")]
[ApiController]
public class BaseNameController<TEntity> : BaseController<TEntity> where TEntity : BaseName
{
    private readonly IBaseNameUnitOfWork<TEntity> _unitOfWork;
    public BaseNameController(IBaseNameUnitOfWork<TEntity> unitOfWork) : base(unitOfWork) { _unitOfWork = unitOfWork; }

    [HttpGet]
    public virtual async Task<List<TEntity>> Get(string name) => await _unitOfWork.FindByName(name);
}
