namespace Infrastructure.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Domain.Models;

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(nameof(Department), "HumanResources");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("DepartmentID");
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.GroupName).IsRequired();
        }
    }
}
