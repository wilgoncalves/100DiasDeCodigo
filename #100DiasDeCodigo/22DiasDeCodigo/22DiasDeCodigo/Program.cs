using _22DiasDeCodigo;
// Generics
// Permitem que classes, interfaces e métodos
// possam ser parametrizados por tipos.

// Ao definir um tipo genérico na classe, podemos instanciar qualquer tipo de variável.
PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine()!); 
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());