// Resolvendo questões do BeeCrowd

// Números ímpares - Link da questão: https://judge.beecrowd.com/pt/problems/view/1067

int num = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

// Mês - Link da questão: https://judge.beecrowd.com/pt/problems/view/1052

int monthNumber = int.Parse(Console.ReadLine()!);

switch (monthNumber)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        break;
}

// Números pares - Link da questão: https://judge.beecrowd.com/pt/problems/view/1059

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// Quadrado de pares - Link da questão: https://judge.beecrowd.com/pt/problems/view/1073

int num = int.Parse(Console.ReadLine()!);

for  (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    {
        double quadrado = Math.Pow(i, 2);
        Console.WriteLine($"{i}^2 = {quadrado}");
    }
}