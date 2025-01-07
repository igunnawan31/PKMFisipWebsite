using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book>? Books { get; set; }        
    public DbSet<Author>? Authors { get; set; }
    public DbSet<Authorship>? Authorships { get; set; }
    public DbSet<Publisher>? Publishers { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<BookPublished>? BookPublisheds { get; set; }
    public DbSet<IsReading>? IsReadings { get; set; }
    public DbSet<HasRead>? HasReads { get; set; }
    public DbSet<ReadLater>? ReadLaters { get; set; }


}