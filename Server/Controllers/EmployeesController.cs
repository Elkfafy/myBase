namespace myBase.Server;

[Route("api/[Controller]")]
[ApiController]
public class EmployeesController<TEntity> : BaseNameController<TEntity> where TEntity : Employee
{
    public EmployeesController(IEmployeeUnitOfWork<TEntity> unitOfWork) : base(unitOfWork) { }
}
