using Liskov_Substitution;

Funcionario func1 = new Gerente("Paulo", "Cargo");
Console.WriteLine(func1.GetType());

Funcionario func2 = new Vendedor("Maria", "Cargo");
Console.WriteLine(func2.GetType());

// Violação do princípio LSP, a classe base Funcionario
// não acessa métodos das classes derivadas.
//Console.WriteLine("Salário do gerente:");
//var salario1 = func1.CalcularSalario(5000);
//Console.WriteLine(salario1);

//Console.WriteLine("Salário do vendedor:");
//var salario2 = func2.CalcularSalario(3000);
//Console.WriteLine(salario2);
//----------------------------------------------

Console.WriteLine("Salário do gerente:");
var salario1 = func1.CalcularSalario(5000);
Console.WriteLine(salario1);

Console.WriteLine("Salário do vendedor:");
var salario2 = func2.CalcularSalario(3000);
Console.WriteLine(salario2);