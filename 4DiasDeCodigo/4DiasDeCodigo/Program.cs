// Copiando arquivos, exemplo 1:

string sourcePath = @"C:\Users\wilsa\OneDrive\Desktop\file1.txt";
string targetPath = @"C:\Users\wilsa\OneDrive\Desktop\file2.txt";

try
{
    File.Copy(sourcePath, targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

// Copiando arquivos, exemplo 2:

string sourcePath = @"C:\Users\wilsa\OneDrive\Desktop\file1.txt";
string targetPath = @"C:\Users\wilsa\OneDrive\Desktop\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

// Lendo arquivos, exemplo 1:

string path = @"C:\Users\wilsa\OneDrive\Desktop\file1.txt";
FileStream fs = null!;
StreamReader sr = null!;

try
{
    fs = new FileStream(path, FileMode.Open); // ou File.OpenRead(path);
    sr = new StreamReader(fs);
    string line = sr.ReadLine()!;
    Console.WriteLine(line);
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null)
        sr.Close();
    if (fs != null)
        fs.Close();
}

// Lendo arquivos, exemplo 2:

string path = @"C:\Users\wilsa\OneDrive\Desktop\file1.txt";

StreamReader sr = null!;
try
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine()!;
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null)
        sr.Close();
}

// Escrevendo caracteres:

string sourcePath = @"C:\Users\wilsa\OneDrive\Desktop\file1.txt";
string targetPath = @"C:\Users\wilsa\OneDrive\Desktop\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
            sw.WriteLine(line.ToUpper());
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}