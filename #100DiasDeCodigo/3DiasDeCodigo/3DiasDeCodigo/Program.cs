// Lendo arquivos

const string filePath = @"C:\Users\wilsa\OneDrive\Desktop\file-text.txt";

// 1.
var data = File.ReadAllText(filePath);
Console.WriteLine(data);

// 2.
var data = File.ReadAllLines(filePath);
var count = 0;
foreach (var line in data)
{
    count++;
    Console.WriteLine($"Linha: {count} - {line}");
}

// 3.
using var file = new StreamReader(filePath);
string? line;

while ((line = file.ReadLine()) != null)
    Console.WriteLine(line);

file.Close();



