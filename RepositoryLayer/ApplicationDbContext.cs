using DomainLayer.EntityMapper;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected void onModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            base.OnModelCreating(modelBuilder); 
        }
    }
    
}