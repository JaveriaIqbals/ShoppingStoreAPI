using Microsoft.EntityFrameworkCore;
using ShoppingStoreAPI.DATA;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IShopService, ShopService>();

builder.Services.AddControllers(); // Added API Controller Service.
builder.Services.AddSwaggerGen(); // Added Swagger Service.


/*builder.Services.AddDbContext<ShoppingStoreDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
});*/
var connectionString = builder.Configuration.GetConnectionString("conn");
builder.Services.AddDbContext<ShoppingStoreDbContext>(options =>
    options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers(); // Mapped API Controller (CustomerController.cs)

app.MapRazorPages();

app.Run();
