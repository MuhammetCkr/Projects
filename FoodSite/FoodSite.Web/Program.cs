using FoodSite.Business.Abstract;
using FoodSite.Business.Concrete;
using FoodSite.Data.Abstract;
using FoodSite.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoodContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddScoped<IFoodService, FoodManager>();
builder.Services.AddScoped<IFoodRepository, EfCoreFoodRepository>();
builder.Services.AddScoped<IMaterialService, MaterialManager>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IMaterialRepository, EfCoreMaterialRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "foods",
    pattern: "foods/{url}",
    defaults: new { controller = "Food", action = "Index" }
    );
app.MapControllerRoute(
    name: "foodsByCategory",
    defaults: new {controller="Food", action="FoodList"},
    pattern:"foods/categories/{category?}"
    );
app.MapControllerRoute(
    name: "details",
    pattern: "food/{id}",
    defaults: new { controller = "Food", action = "Details" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
