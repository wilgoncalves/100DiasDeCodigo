using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;
using RangoAgil.API.EndpointHandlers;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    x => x.UseSqlite(builder.Configuration["ConnectionStrings:RangoDbConnectionString"])
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Agrupando endpoints
var rangosEndpoints = app.MapGroup("/rangos");
var rangosComIdEndpoints = rangosEndpoints.MapGroup("{rangoId:int}");
var ingredientesEndpoints = rangosComIdEndpoints.MapGroup("/ingredientes");

rangosEndpoints.MapGet("", RangosHandlers.GetRangosAsync);

ingredientesEndpoints.MapGet("", IngredientesHandlers.GetIngredientesAsync);

rangosComIdEndpoints.MapGet("", RangosHandlers.GetRangoById).WithName("GetRangos");

rangosEndpoints.MapPost("", RangosHandlers.CreateRangoAsync);

rangosComIdEndpoints.MapPut("", RangosHandlers.UpdateRangoAsync);

rangosComIdEndpoints.MapDelete("", RangosHandlers.DeleteRangoAsync);

app.Run();
