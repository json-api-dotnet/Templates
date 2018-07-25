using Microsoft.EntityFrameworkCore;

namespace _JADNC.App
{
  public class SampleDbContext : DbContext
  {
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
    : base(options)
    { }

    public DbSet<SampleModel> SampleModels { get; set; }
  }
}