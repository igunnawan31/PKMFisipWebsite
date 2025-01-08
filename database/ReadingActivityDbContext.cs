using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
public class ReadingActivityDbContext:DbContext{
    public ReadingActivityDbContext(DbContextOptions<ReadingActivityDbContext> options)
        : base(options)
    {
    }
    public DbSet<HasRead>? HasReads {get; set;}
    public DbSet<IsReading>? IsReadings {get; set;}
    public DbSet<ReadLater>? ReadLaters { get; set; }
}