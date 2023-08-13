using Microsoft.EntityFrameworkCore;
namespace SingleOrFirstBenchmark
{
    public class SingleOrFirstDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SingleOrFirstBenchmark1;User Id=sa;Password=SoranAhmadi@1992;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
