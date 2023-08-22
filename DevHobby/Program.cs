using DevHobby.Models;
using DevHobby.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DevHobbyDbContextConnection") ?? throw new InvalidOperationException("Connection string 'DevHobbyDbContextConnection' not found.");

builder.Services.AddDbContext<DevHobbyDbContext>(options =>
{
    options.UseSqlServer(
         builder.Configuration["ConnectionStrings:DevHobbyDbContextConnection"]);
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DevHobbyDbContext>();


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>(); 
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseAuthentication();
app.UseStaticFiles();
app.UseSession();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();        //"{controller=Home}/{action=Index}/{id?}
app.MapRazorPages();

DbInitializer.Seed(app);

app.Run();
