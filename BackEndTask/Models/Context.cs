using Microsoft.EntityFrameworkCore;

namespace BackEndTask.Models
{
    public class Context:DbContext
    {
        public Context()
        {
            
        }
        public Context(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
