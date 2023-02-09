namespace myBase.Server;

public class EmployeeConfiguration<TEntity> : BaseNameConfiguration<TEntity> where TEntity : Employee
{
    public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.Salary).IsRequired().HasMaxLength(10);
    }
}
