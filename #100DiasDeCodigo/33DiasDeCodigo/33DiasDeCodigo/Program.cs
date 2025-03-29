using System.Globalization;

// Resolução de questões - BeeCrowd

// 1. Diferença - link da questão: https://judge.beecrowd.com/pt/problems/view/1007

int[] vet = new int[4];
int num;

for (int i = 0; i <= 3; i++)
{
    num = int.Parse(Console.ReadLine()!);
    vet[i] = num;
}

int diferenca = (vet[0] * vet[1] - vet[2] * vet[3]);
Console.WriteLine($"DIFERENCA = {diferenca}");

// 2. Lanche - link da questão: https://judge.beecrowd.com/pt/problems/view/1038


string[] vet = Console.ReadLine()!.Split(' ');
int codigo = int.Parse(vet[0]);
int quant = int.Parse(vet[1]);
double total;

switch (codigo)
{
    case 1:
        total = quant * 4.00;
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 2:
        total = quant * 4.50;
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 3:
        total = quant * 5.00;
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 4:
        total = quant * 2.00;
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 5:
        total = quant * 1.50;
        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        break;
}


// 3. Pares entre cinco números - link da questão: https://judge.beecrowd.com/pt/problems/view/1065

int num;
int count = 0;

for  (int i = 0; i <= 4; i++)
{
    num = int.Parse(Console.ReadLine()!);
    if (num % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"{count} valores pares");