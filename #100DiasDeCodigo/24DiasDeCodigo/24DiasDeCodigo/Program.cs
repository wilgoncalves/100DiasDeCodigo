using _24DiasDeCodigo.Entities;

// GetHashCode e Equals
// São operações da classe Object utilizadas para
// comparar se um objeto é igual a outro.

// Equals: lento, resposta 100%

string a = "Maria";
string b = "Alex";
string c = "Maria";

Console.WriteLine(a.Equals(b));
Console.WriteLine(a.Equals(c));

// GetHashCode: retorna um número inteiro representando um código.

string d = "Maria";
string e = "Alex";
string f = "Maria";

Console.WriteLine(d.GetHashCode());
Console.WriteLine(e.GetHashCode());
Console.WriteLine(f.GetHashCode());


// Comparando clientes

Client g = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client h = new Client { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine(g.Equals(h));
Console.WriteLine(g == h);
Console.WriteLine(g.GetHashCode());
Console.WriteLine(h.GetHashCode());