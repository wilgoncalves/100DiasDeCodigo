// Resolvendo questões no BeeCrowd
using System.Globalization;

// Tipos de triângulos - link da questão: https://judge.beecrowd.com/pt/problems/view/1045

string[] values = Console.ReadLine()!.Split(' ');
double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
double n3 = double.Parse(values[2], CultureInfo.InvariantCulture);

if (n2 > n1)
{
    double num = n1;
    n1 = n2;
    n2 = num;
}
if (n3 > n1)
{
    double num = n1;
    n1 = n3;
    n3 = num;
}
if (n3 > n2)
{
    double num = n2;
    n2 = n3;
    n3 = num;
}

double n1AoQuadrado = Math.Pow(n1, 2);
double n2AoQuadrado = Math.Pow(n2, 2);
double n3AoQuadrado = Math.Pow(n3, 2);

if (n1 >= (n2 + n3))
    Console.WriteLine("NAO FORMA TRIANGULO");
else
{
    if (n1AoQuadrado == (n2AoQuadrado + n3AoQuadrado))
        Console.WriteLine("TRIANGULO RETANGULO");
    if (n1AoQuadrado > (n2AoQuadrado + n3AoQuadrado))
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    if (n1AoQuadrado < (n2AoQuadrado + n3AoQuadrado))
        Console.WriteLine("TRIANGULO ACUTANGULO");
    if (n1 == n2 && n2 == n3)
        Console.WriteLine("TRIANGULO EQUILATERO");
    if ((n1 == n2 && n1 != n3) || (n2 == n3 && n2 != n1) || (n3 == n1 && n3 != n2))
        Console.WriteLine("TRIANGULO ISOSCELES");
}

// Senha fixa - link da questão: https://judge.beecrowd.com/pt/problems/view/1114


int senhaCorreta = 2002;

while (true)
{
    int senha = int.Parse(Console.ReadLine()!);
    if (senha == senhaCorreta)
    {
        Console.WriteLine("Acesso Permitido");
        break;
    }
    else
        Console.WriteLine("Senha Invalida");
}