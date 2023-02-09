namespace myBase.Server;

public class TeacherConfiguration<TEntity> : EmployeeConfiguration<TEntity>
    where TEntity : Teacher
{
    public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.Salary).IsRequired().HasMaxLength(10);
    }
}
