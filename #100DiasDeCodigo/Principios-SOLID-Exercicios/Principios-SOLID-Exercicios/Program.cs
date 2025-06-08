using Principios_SOLID_Exercicios;
using System.Globalization;

Produto celular = new Celular(new PromocaoDiaDasMaes());
celular.Nome = "Celular Samsung Galaxy M10";
celular.Valor = 1000;
var valorCelular = celular.ValorVenda();
Console.WriteLine($"{celular.Nome} (20% Off): {valorCelular.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine();

Produto perfume = new Perfume(new PromocaoDiaDosNamorados());
perfume.Nome = "Perfume Channel Blue";
perfume.Valor = 500;
var valorPerfume = perfume.ValorVenda();
Console.WriteLine($"{perfume.Nome} (10% Off): {valorPerfume.ToString("F2", CultureInfo.InvariantCulture)}");
