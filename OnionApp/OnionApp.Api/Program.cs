using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionApp.Application.Services;
using OnionApp.Domain;
using OnionApp.Domain.Repositories.CompanyRepositories;
using OnionApp.Domain.Repositories.OrderRepositories;
using OnionApp.Domain.Repositories.ProductRepositories;
using OnionApp.Persistence;
using OnionApp.Persistence.Context;
using OnionApp.Persistence.Repositories.CompanyRepositories;
using OnionApp.Persistence.Repositories.OrderRepositories;
using OnionApp.Persistence.Repositories.ProductRepositories;
using OnionApp.Persistence.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(typeof(OnionApp.Application.AssemblyReferance).Assembly);
builder.Services.AddScoped<IProductCommandRepository,ProductCommandRepository>();
builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<ICompanyCommandRepositoy, CompanyCommandRepositoy>();
builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


builder.Services.AddControllers()
    .AddApplicationPart(typeof(OnionApp.Presentation.AssemblyReferance).Assembly);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
