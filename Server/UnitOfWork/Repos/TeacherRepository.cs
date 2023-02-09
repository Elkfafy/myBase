namespace myBase.Server;

public class TeacherRepository<TEntity> : EmployeeRepository<TEntity>, ITeacherRepository<TEntity>
    where TEntity : Teacher
{
    public TeacherRepository(ApplicationDbContext dbContext) : base(dbContext) { }
}
