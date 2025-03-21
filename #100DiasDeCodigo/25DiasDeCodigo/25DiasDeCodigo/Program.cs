using System.Globalization;

// Resolução de questões - BeeCrowd

// 1. Ho Ho Ho - link da questão: https://judge.beecrowd.com/pt/problems/view/1759

int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i < n; i++)
{
    Console.Write("Ho ");
}
Console.WriteLine("Ho!");

// 2. Esfera - link da questão: https://judge.beecrowd.com/pt/problems/view/1011

double r = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double volume = (4.0 / 3) * 3.14159 * Math.Pow(r, 3);

Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");

// 3. Fórmula de bhaskara - link da questão: https://judge.beecrowd.com/pt/problems/view/1036

string[] vet = Console.ReadLine()!.Split(' ');
double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
double c  = double.Parse(vet[2], CultureInfo.InvariantCulture);

double delta = Math.Pow(b, 2) - (4 * a * c);

if (delta < 0 || a == 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
}
    



