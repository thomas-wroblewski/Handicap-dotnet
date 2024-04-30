using Handicap.Entities;
using Microsoft.EntityFrameworkCore;

namespace Handicap;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<WeatherForecast> Forecasts { get; set; }
    
    public DbSet<Round> Rounds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasSequence<int>("round_id_seq");

        modelBuilder.Entity<Round>().Property(r => r.Id).HasDefaultValueSql("nextval('round_id_seq')");
    }

}