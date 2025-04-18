using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    x => x.UseSqlite(builder.Configuration["ConnectionStrings.RangoDbConnectionString"])
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
