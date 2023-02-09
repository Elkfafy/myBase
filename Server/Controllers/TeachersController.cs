namespace myBase.Server;

[Route("api/[controller]")]
[ApiController]
public class TeachersController<TEntity> : EmployeesController<TEntity>
    where TEntity : Teacher
{
    public TeachersController(ITeacherUnitOfWork<TEntity> unitOfWork) : base(unitOfWork) { }
}
