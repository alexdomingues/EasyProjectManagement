using EasyProjectManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace EasyProjectManagement.Server
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) 
        {

        }
        
        // Create table
        public DbSet<Project> Projects { get; set; }

    }
}
