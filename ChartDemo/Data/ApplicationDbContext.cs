using Microsoft.EntityFrameworkCore;
using ChartDemo.Models;

namespace ChartDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public DbSet<ProgrammeSummary> ProgrammeSummary { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
