// Estrutura try-catch

try
{
    int n1 = int.Parse(Console.ReadLine()!);
    int n2 = int.Parse(Console.ReadLine()!);

    int result = n1 / n2;
    // O programa lançará uma exceção caso o valor de n2 seja 0.
    Console.WriteLine(result);
}
// Superclasse Exception (Upcasting)
//catch (Exception e)
//{
//    Console.WriteLine("Error! " + e.Message);
//}
// OU
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not allowed");
}
// Exceção será capturada se um dos valores de entrada for string.
catch (FormatException e)
{
    Console.WriteLine("Format error! " + e.Message);
}

// Recurso finally

FileStream fs = null!;

try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine()!;
    Console.WriteLine(line);
}
// Exceção capturada caso o arquivo não seja encontrado.
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
// Mesmo que não haja uma exceção, garantimos que o arquivo será fechado com o bloco finally.
finally
{
    if (fs != null)
    {
        fs.Close();
    }
}

