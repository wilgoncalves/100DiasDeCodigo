using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;
using RangoAgil.API.Entities;
using RangoAgil.API.Models;

namespace RangoAgil.API.EndpointHandlers;

public static class RangosHandlers
{
    public static async Task<Results<NoContent, Ok<IEnumerable<RangoDTO>>>> GetRangosAsync
        (RangoDbContext rangoDbContext,
        IMapper mapper,
        ILogger<RangoDTO> logger,
        [FromQuery(Name = "name")] string? rangoNome)
    {
        var result = await rangoDbContext.Rangos
                                   .Where(x => rangoNome == null || x.Name.ToLower()
                                   .Contains(rangoNome.ToLower()))
                                   .ToListAsync();

        if (result.Count <= 0 || result == null)
        {
            logger.LogInformation($"Rango não encontrado. Parâmetro: {rangoNome}");
            return TypedResults.NoContent();
        }
        else
        {
            logger.LogInformation("Retornando o Rango encontrado.");
            return TypedResults.Ok(mapper.Map<IEnumerable<RangoDTO>>(result));
        }  
    }

    public static async Task<Results<NoContent, Ok<RangoDTO>>> GetRangoById
    (RangoDbContext rangoDbContext,
    IMapper mapper,
    int rangoId)
    {
        var result = mapper.Map<RangoDTO>(await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId));
    
        if (result == null)
            return TypedResults.NoContent();
        else
            return TypedResults.Ok(result);

    }

    public static async Task<Results<CreatedAtRoute<RangoDTO>, BadRequest>> CreateRangoAsync
    (RangoDbContext rangoDbContext,
    IMapper mapper,
    [FromBody] RangoParaCriacaoDTO? rangoParaCriacaoDTO)
    {   
        if (rangoParaCriacaoDTO == null || string.IsNullOrEmpty(rangoParaCriacaoDTO.Name)) 
            return TypedResults.BadRequest();
    
        var rangos = await rangoDbContext
                            .Rangos
                            .Where(x => x.Name == rangoParaCriacaoDTO.Name).ToListAsync();

        if (rangos.Count <= 0)
        {
            var result = mapper.Map<Rango>(rangoParaCriacaoDTO);
            rangoDbContext.Add(result);
            await rangoDbContext.SaveChangesAsync();

            var rangoToReturn = mapper.Map<RangoDTO>(result);

            // Como retornar o link desejado:
            return TypedResults.CreatedAtRoute(
                rangoToReturn,
                "GetRangos",
                new { rangoId = rangoToReturn.Id});

        }
        else
        {
            return TypedResults.BadRequest();
        }
    }

    public static async Task<Results<NotFound, Ok>> UpdateRangoAsync
    (RangoDbContext rangoDbContext,
    IMapper mapper,
    [FromBody] RangoParaAtualizacaoDTO rangoParaAtualizacaoDTO,
    int rangoId)
    {
        var result = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

        if (result == null)
            return TypedResults.NotFound();

        mapper.Map(rangoParaAtualizacaoDTO, result);

        await rangoDbContext.SaveChangesAsync();
        return TypedResults.Ok();
    }

    public static async Task<Results<NotFound, NoContent>> DeleteRangoAsync
    (RangoDbContext rangoDbContext,
    int rangoId) 
    {
        var result = await rangoDbContext.Rangos.FirstOrDefaultAsync(x => x.Id == rangoId);

        if (result == null)
            return TypedResults.NotFound();

        rangoDbContext.Rangos.Remove(result);

        await rangoDbContext.SaveChangesAsync();
        return TypedResults.NoContent();
    }
}

