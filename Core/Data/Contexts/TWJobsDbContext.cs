using Microsoft.EntityFrameworkCore;
using TWJobs.Core.Data.EntityConfigs;
using TWJobs.Core.Models;

namespace TWJobs.Core.Data.Contexts;

public class TWJobsDbContext : DbContext
{
    public DbSet<Job> Jobs => Set<Job>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=DESKTOP-HICF4KH\\SQLEXPRESSOFC;Database=TWJobs;User Id=sa;Password=root;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new JobEntityConfig());
    }
}