using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;
using RangoAgil.API.Entities;
using RangoAgil.API.Models;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    x => x.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rangos", async Task<Results<NoContent, Ok<IEnumerable<RangoDTO>>>>
    (RangoDbContext rangoDbContext, 
    IMapper mapper,
    [FromQuery(Name = "name")] string? rangoNome) =>
{
    var result = await rangoDbContext.Rangos
                               .Where(x => rangoNome == null || x.Name.ToLower()
                               .Contains(rangoNome.ToLower()))
                               .ToListAsync();

    if (result.Count <= 0 || result == null)
        return TypedResults.NoContent();
    else
        return TypedResults.Ok(mapper.Map<IEnumerable<RangoDTO>>(result));
});

app.MapGet("/rangos/{rangoId:int}/ingredientes", async (
    RangoDbContext rangoDbContext, 
    IMapper mapper,
    int rangoId) =>
{
    var result = mapper.Map<IEnumerable<IngredienteDTO>>((await rangoDbContext.Rangos
                               .Include(rango => rango.Ingredientes)
                               .FirstOrDefaultAsync(rango => rango.Id == rangoId))?.Ingredientes);

    //if (result.Count <= 0 || result == null)
    //    return TypedResults.NoContent();

    //return TypedResults.Ok(mapper.Map<IEnumerable<IngredienteDTO>>(result).FirstOrDefault());

});

app.MapGet("/rangos/{rangoId:int}", async (
    RangoDbContext rangoDbContext, 
    IMapper mapper,
    int rangoId) =>
{
    return mapper.Map<RangoDTO>(await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId));
}).WithName("GetRangos");

app.MapPost("/rangos", async Task<CreatedAtRoute<RangoDTO>> (
    RangoDbContext rangoDbContext,
    IMapper mapper,
    [FromBody] RangoParaCriacaoDTO rangoParaCriacaoDTO
    //LinkGenerator linkGenerator,
    //HttpContext httpContext
    )=>
{
    var result = mapper.Map<Rango>(rangoParaCriacaoDTO);
    rangoDbContext.Add(result);
    await rangoDbContext.SaveChangesAsync();

    var rangoToReturn = mapper.Map<RangoDTO>(result);

    // Como retornar o link desejado:
    return TypedResults.CreatedAtRoute(
        rangoToReturn, 
        "GetRangos", 
        new { rangoId = rangoToReturn.Id });

    // Como retornar o link desejado 2:
    //var linkToReturn = linkGenerator.GetUriByName(
    //    httpContext,
    //    "GetRango",
    //    new { rangoId = rangoToReturn.Id });

    //return TypedResults.Created(linkToReturn, rangoToReturn);
});

app.MapPut("/rangos/{rangoId:int}", async Task<Results<NotFound, Ok>> (
    RangoDbContext rangoDbContext,
    IMapper mapper,
    [FromBody] RangoParaAtualizacaoDTO rangoParaAtualizacaoDTO,
    int rangoId) =>
{
    var result = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

    if (result == null)
        return TypedResults.NotFound();

    mapper.Map(rangoParaAtualizacaoDTO, result);

    await rangoDbContext.SaveChangesAsync();
    return TypedResults.Ok();
});

app.MapDelete("/rangos/{rangoId:int}", async Task<Results<NotFound, NoContent>> (
    RangoDbContext rangoDbContext,
    int rangoId) =>
{
    var result = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

    if (result == null)
        return TypedResults.NotFound();

    rangoDbContext.Rangos.Remove(result);

    await rangoDbContext.SaveChangesAsync();
    return TypedResults.NoContent();
});

app.Run();
