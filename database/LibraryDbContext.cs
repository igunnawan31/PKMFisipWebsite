using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
public class LibraryDbContext:DbContext{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }
    public DbSet<Book>? Books {get; set;}
    public DbSet<Author>? Authors {get; set;}
    public DbSet<Authorship>? Authorships { get; set; }
    public DbSet<Publisher>? Publishers {get; set;}
    public DbSet<BookPublished>? BooksPublished {get; set;}

}