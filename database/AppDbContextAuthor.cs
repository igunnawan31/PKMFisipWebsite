using System.Security.Cryptography.X509Certificates;

namespace PKMFisipWebsite.Database;

using Microsoft.EntityFrameworkCore;
public class AppDbContextAuthor:DbContext{
    public AppDbContextAuthor(DbContextOptions<AppDbContextAuthor> options)
        : base(options)
    {
    }
 
    public DbSet<Author>? Authors { get; set; }
}