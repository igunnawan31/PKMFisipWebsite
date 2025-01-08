using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
public class UserDbContext:DbContext{
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }
    public DbSet<User>? Users { get; set; }

}