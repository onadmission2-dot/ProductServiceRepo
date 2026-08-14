using Microsoft.EntityFrameworkCore;
using ProductServiceDeployment.Data;
using ProductServiceDeployment.Operations;
using ProductServiceDeployment.Service;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

// Configure Entity Framework Core
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Register application services
builder.Services.AddScoped<IProductOperation, ProductServices>();

// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();