using Microsoft.EntityFrameworkCore;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.BusinessLogic.Services;
using ShoppingListBE.DataAccess;
using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using ShoppingListBE.DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShoppingListDBContext>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("ConnectionString");

    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IClientService, ClientService>();

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

app.Run();
