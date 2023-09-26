using CRUD_28.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_28.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
