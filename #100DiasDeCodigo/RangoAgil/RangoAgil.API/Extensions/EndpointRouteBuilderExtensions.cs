using RangoAgil.API.EndpointFilters;
using RangoAgil.API.EndpointHandlers;

namespace RangoAgil.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void RegistrarRangosEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var rangosEndpoints = endpointRouteBuilder.MapGroup("/rangos");
        var rangosComIdEndpoints = rangosEndpoints.MapGroup("{rangoId:int}");
        var rangosComIdEndpointsAndLockFilter = rangosComIdEndpoints
            .AddEndpointFilter(new RangoIsLockedFilter(27))
            .AddEndpointFilter(new RangoIsLockedFilter(8));
            // Chain of responsability

        rangosEndpoints.MapGet("", RangosHandlers.GetRangosAsync);

        rangosComIdEndpoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos");

        rangosEndpoints.MapPost("", RangosHandlers.CreateRangoAsync);

        rangosComIdEndpointsAndLockFilter.MapPut("", RangosHandlers.UpdateRangoAsync);

        rangosComIdEndpointsAndLockFilter.MapDelete("", RangosHandlers.DeleteRangoAsync);
    }

    public static void RegistrarIngredientesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var ingredientesEndpoints = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}/ingredientes");

        ingredientesEndpoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);
        ingredientesEndpoints.MapPost("", () =>
        {
            throw new NotImplementedException();
        });
    }
}

