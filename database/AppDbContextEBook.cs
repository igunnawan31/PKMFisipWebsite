using System.Security.Cryptography.X509Certificates;

namespace PKMFisipWebsite.Database;

using Microsoft.EntityFrameworkCore;
public class AppDbContextEBook:DbContext{
    public AppDbContextEBook(DbContextOptions<AppDbContextEBook> options)
        : base(options)
    {
    }
 
    public DbSet<EBook>? EBooks { get; set; }
}