using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    x => x.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rango/{nome}", (RangoDbContext rangoDbContext, string nome) =>
{
    return rangoDbContext.Rangos.FirstOrDefault(x => x.Name == nome);
});

app.MapGet("/rango", (RangoDbContext rangoDbContext, [FromQuery(Name = "RangoId")]int id) =>
{
    return rangoDbContext.Rangos.FirstOrDefault(x => x.Id == id);
});

app.MapGet("/rangos", (RangoDbContext rangoDbContext) =>
{
    return rangoDbContext.Rangos;
});

app.Run();
 