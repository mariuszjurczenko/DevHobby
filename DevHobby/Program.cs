using DevHobby.Models;
using DevHobby.Models.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DevHobbyDbContext>(options =>
{
    options.UseSqlServer(
         builder.Configuration["ConnectionStrings:DevHobbyDbContextConnection"]);
});


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<ICourseRepository, MockCourseRepository>();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
