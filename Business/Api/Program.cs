using Infrastructure.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSqlServer<BusinessContext>(builder.Configuration.GetConnectionString("cnBusiness"));

builder.Services.AddDbContext<BusinessContext>(
    options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("cnBusiness"),
            x => x.MigrationsAssembly("Infrastructure.BusinessContext")));

var app = builder.Build();

app.MapGet("/dbconnection", async ([FromServices] BusinessContext dbcontext) =>
{
    dbcontext.Database.EnsureCreated();
    return Results.Ok();
});

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
