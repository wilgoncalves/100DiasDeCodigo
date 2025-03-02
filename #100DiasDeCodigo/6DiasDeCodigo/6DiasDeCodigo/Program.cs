using System.Globalization;

// Exercícios resolvidos - BEECROWD

// 1. Link de acesso ao problema - https://judge.beecrowd.com/pt/problems/view/1010

double[] result = new double[2];
for (int i = 0; i <= 1; i++)
{
    string[] peca = Console.ReadLine()!.Split(' ');

    int codigoPeca = int.Parse(peca[0]);
    int numeroPeca = int.Parse(peca[1]);
    double valorPeca = double.Parse(peca[2], CultureInfo.InvariantCulture);

    result[i] = valorPeca * numeroPeca;
}

double valorAPagar = result[0] + result[1];

Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
Console.ReadLine();


// 2. Link de acesso ao problema - https://judge.beecrowd.com/pt/problems/view/1012

string[] valor = Console.ReadLine()!.Split(' ');
double valorA = double.Parse(valor[0], CultureInfo.InvariantCulture);
double valorB = double.Parse(valor[1], CultureInfo.InvariantCulture);
double valorC = double.Parse(valor[2], CultureInfo.InvariantCulture);

double areaTriangulo = (valorA * valorC) / 2.0;
double areaCirculo = 3.14159 * Math.Pow(valorC, 2.0);
double areaTrapezio = (valorA + valorB) * valorC / 2.0;
double areaQuadrado = Math.Pow(valorB, 2);
double areaRetangulo = valorA * valorB;

Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
Console.ReadLine();





