using Open_Closed_Principle;
using Open_Closed_Principle.Extensions;
using System.Globalization;

Produto produto1 = new(
    1,
    "Caneta",
    "Caneta esferográfica azul",
    100,
    true,
    2.00M,
    3.40M
    );

Console.WriteLine($"{produto1.Nome}, Lucro: {produto1.MargemLucro()
    .ToString("F2", CultureInfo.InvariantCulture)}%");

