using EasyProjectManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace EasyProjectManagement.Server
{
    public class ApplicationDBContext : DbContext
    {
        /* Add entities(class) to create, update, delete database structure */
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) 
        {

        }
        
        // Create table
        public DbSet<Project> Projects { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
