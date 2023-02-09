namespace myBase.Server;

public class BaseNameConfiguration<TEntity> : BaseConfiguration<TEntity>
    where TEntity : BaseName
{
    public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
    }
}
