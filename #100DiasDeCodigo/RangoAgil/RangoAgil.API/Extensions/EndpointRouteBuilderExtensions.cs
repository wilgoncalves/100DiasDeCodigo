using RangoAgil.API.EndpointFilters;
using RangoAgil.API.EndpointHandlers;

namespace RangoAgil.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void RegistrarRangosEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapGet("/pratos/{pratoId:int}", (int pratoId) => $"O prato {pratoId} é delicioso!")
            .WithOpenApi(operation =>
            {
                operation.Deprecated = true;
                return operation;
            })
            .WithSummary("Este endpoint está deprecated e será descontinuado na versão 2 da API.")
            .WithDescription("Utilize a outra rota da API >> /rangos/{rangoId} para evitar maiores transtornos");

        var rangosEndpoints = endpointRouteBuilder.MapGroup("/rangos").RequireAuthorization();

        var rangosComIdEndpoints = rangosEndpoints.MapGroup("{rangoId:int}");

        var rangosComIdEndpointsAndLockFilter = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}")
            .RequireAuthorization()
            .AddEndpointFilter(new RangoIsLockedFilter(27))
            .AddEndpointFilter(new RangoIsLockedFilter(8));
        // Chain of responsability

        rangosEndpoints.MapGet("", RangosHandlers.GetRangosAsync)
            .WithOpenApi()
            .WithSummary("Esta rota retornará todos os Rangos");

        rangosComIdEndpoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos")
            .AllowAnonymous();

        rangosEndpoints.MapPost("", RangosHandlers.CreateRangoAsync)
            .AddEndpointFilter<ValidateAnnotationFilter>();

        rangosComIdEndpointsAndLockFilter.MapPut("", RangosHandlers.UpdateRangoAsync);

        rangosComIdEndpointsAndLockFilter.MapDelete("", RangosHandlers.DeleteRangoAsync)
            .AddEndpointFilter<LogNotFoundResponseFilter>();
    }

    public static void RegistrarIngredientesEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        var ingredientesEndpoints = endpointRouteBuilder.MapGroup("/rangos/{rangoId:int}/ingredientes")
            .RequireAuthorization();

        ingredientesEndpoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);

        ingredientesEndpoints.MapPost("", () =>
        {
            throw new NotImplementedException();
        });
    }
}

