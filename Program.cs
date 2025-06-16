using gigabyte_homework.Models.Application;
using gigabyte_homework.Services.Product;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
{
    options.UseInMemoryDatabase("ProductDb");
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient<IProductService, ProductService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //dbContext.Database.Migrate(); // 自動執行 migration
    DbInitializer.Seed(dbContext); // 種子資料
}

app.Run();
