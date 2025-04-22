using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;
using RangoAgil.API.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    x => x.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rangos", async Task<Results<NoContent, Ok<List<Rango>>>>
    (RangoDbContext rangoDbContext, 
    [FromQuery(Name = "name")] string? rangoNome) =>
{
    var result = await rangoDbContext.Rangos
                               .Where(x => rangoNome == null || x.Name.ToLower()
                               .Contains(rangoNome.ToLower()))
                               .ToListAsync();

    if (result.Count <= 0 || result == null)
        return TypedResults.NoContent();
    else
        return TypedResults.Ok(result);
});

app.MapGet("/rango/{id:int}", async (RangoDbContext rangoDbContext, int id) =>
{
    return await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == id);
});

app.Run();
