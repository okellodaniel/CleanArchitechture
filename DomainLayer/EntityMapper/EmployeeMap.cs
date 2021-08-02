using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_empId");
                builder.Property(x=> x.Id).ValueGeneratedOnAdd()
                    .HasColumnName("Id").HasColumnType("INT");
                builder.Property(x => x.EmployeeName)
                    .HasColumnName("EmployeeName").HasColumnType("Varchar(100)")
                    .IsRequired();
                builder.Property(x => x.Designation)
                    .HasColumnName("Designation").HasColumnType("Varchar(100)");
                builder.Property(x => x.Department)
                    .HasColumnName("Designation").HasColumnType("Varchar(100)");
                builder.Property(x => x.EntryDate)
                    .HasColumnName("Designation").HasColumnType("datetime");
                builder.Property(x => x.UpdateDate)
                    .HasColumnName("Designation").HasColumnType("datetime");
                builder.Property(x => x.IsActive)
                    .HasColumnName("Designation").HasColumnType("bit");


        }
    }
}