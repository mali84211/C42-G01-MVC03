using C42_G01_MVC03.Data.Configurations;
using C42_G01_MVC03.Models;
using Microsoft.EntityFrameworkCore;

namespace C42_G01_MVC03.Data.Contexts
{
    public class AppDbContext : DbContext 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(configuration:new DepartmentConfigurations());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Server=.;Databaser=CompanyMVCG03; Trusted_Connection =True ;");
        }
        public DbSet<Department> Departments { get; set; }
    }
}
