namespace myBase.Server;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration<Employee>());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration<Teacher>());
    }
}
