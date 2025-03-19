using _23DiasDeCodigo.Services;
using _23DiasDeCodigo.Entities;
using System.Globalization;
// Restrições de Generics

List<Product> list = new List<Product>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    string[] vet = Console.ReadLine()!.Split(',');
    string name = vet[0];
    double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
    
    list.Add(new Product(name, price));
}

CalculationService calculationService = new CalculationService();

Product max = calculationService.Max(list);

Console.WriteLine("Max:");
Console.WriteLine(max);