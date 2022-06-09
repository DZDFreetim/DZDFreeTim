using DZDFreeTim.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DB Baglantýsý

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// Veritabanýný Code First ile oluþtur
using (var scope = app.Services.CreateScope())
{
    // Veritabaný servisine eriþim saðlar.
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // Veritabanýný sil
    db.Database.EnsureDeleted();

    // Veritabanýný oluþturur
    db.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
