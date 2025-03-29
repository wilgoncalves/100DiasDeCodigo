// Operador IS

var someText = "This is a string";

Console.WriteLine(someText.GetType());

// Comparando tipos
var result = someText.GetType() == typeof(string);
// Melhor forma:
var result1 = someText is string;


// Outras comparações
var cpf = new CPF();
if (cpf is Documento)
Console.WriteLine("CPF é um documento");

public record Documento { }
public record CPF : Documento { }
public record CNPJ : Documento { }


// Mais comparações
var student = new Student();
if (student == null)
Console.WriteLine("Nulo");

if (student != null)
Console.WriteLine("Não nulo");

// Aprimorando:
if (student is null)
Console.WriteLine("Nulo");

if (student is not null)
Console.WriteLine("Não nulo");

public record Student { }


// Operador AS

var documento = new Documento();
var cpf = (CPF)documento; // conversão explícita
var cpf2 = documento as CPF; // Aprimorando com AS

public record Documento { }
public record CPF : Documento { }
public record CNPJ : Documento { }