using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using THA_Entitys.Models;
using THA_Entitys.Refactor;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.DatabaseSettings(builder.Configuration);

builder.Services.AddDbContext<AlumniadbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AlumniadbContext>()
    .AddDefaultTokenProviders();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
