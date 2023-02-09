namespace myBase.Shared;

public class TeacherValidator<TEntity> : EmployeeValidator<TEntity> where TEntity : Teacher
{
    public TeacherValidator() : base()
    {
        RuleFor(e => e.Classroom).NotNull();
    }
}
