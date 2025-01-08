using System.Security.Cryptography.X509Certificates;

namespace PKMFisipWebsite.Database;

using Microsoft.EntityFrameworkCore;
public class AppDbContextAudioBook:DbContext{
    public AppDbContextAudioBook(DbContextOptions<AppDbContextAudioBook> options)
        : base(options)
    {
    }
 
    public DbSet<AudioBook>? AudioBooks { get; set; }
}