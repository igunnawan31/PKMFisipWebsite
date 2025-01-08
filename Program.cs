using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using PKMFisipWebsite.Database;

var builder = WebApplication.CreateBuilder(args);
var conString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddMySqlDataSource(conString!);
// Tambahkan DbContext ke dalam container layanan
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseMySQL(conString!));
builder.Services.AddDbContext<ReadingActivityDbContext>(options =>
    options.UseMySQL(conString!));
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseMySQL(conString!));
// Add services to the container.
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.MapControllers();

app.Run();
