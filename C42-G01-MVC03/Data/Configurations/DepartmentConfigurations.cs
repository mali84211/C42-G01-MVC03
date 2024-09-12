using C42_G01_MVC03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace C42_G01_MVC03.Data.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder) {
            builder.Property(D => D.Id).UseIdentityColumn(Seeed: 10, increment = 10);
        }
    }
}
