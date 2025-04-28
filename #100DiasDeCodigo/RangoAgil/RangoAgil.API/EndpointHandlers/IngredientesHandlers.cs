using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;
using RangoAgil.API.Models;

namespace RangoAgil.API.EndpointHandlers;

public static class IngredientesHandlers
{
    public static async Task<Results<NotFound, Ok<IngredienteDTO>>> GetIngredientesAsync
        (RangoDbContext rangoDbContext,
        IMapper mapper,
        int rangoId)
    {
        var result = mapper.Map<IEnumerable<IngredienteDTO>>((await rangoDbContext.Rangos
                                   .Include(rango => rango.Ingredientes)
                                   .FirstOrDefaultAsync(rango => rango.Id == rangoId))?.Ingredientes);

        // Tratando retornos:
        if (!result.Any() || result == null)
            return TypedResults.NotFound();
        else
            return TypedResults.Ok(mapper.Map<IEnumerable<IngredienteDTO>>(result).FirstOrDefault());

    }
}

