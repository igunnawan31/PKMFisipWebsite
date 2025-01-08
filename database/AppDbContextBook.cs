using System.Security.Cryptography.X509Certificates;

namespace PKMFisipWebsite.Database;

using Microsoft.EntityFrameworkCore;
public class AppDbContextBook:DbContext{
    public AppDbContextBook(DbContextOptions<AppDbContextBook> options)
        : base(options)
    {
    }

    public DbSet<Book>? Books { get; set; }

}
