using IdvisTestApp.Databases;
using IdvisTestApp.Entities;
using IdvisTestApp.Entities.Tile;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddScoped<IDbContext, SQLiteContext>()
    .AddScoped<Repository<Tile>>();

builder.Services.AddDatabase(options => {
    options.ConnectionString = builder.Configuration.GetSection("Database").GetValue<string>("ConnectionString");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
