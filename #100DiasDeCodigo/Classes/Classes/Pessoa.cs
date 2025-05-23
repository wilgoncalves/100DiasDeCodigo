namespace Classes;

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Genero { get; set; }

    public Pessoa()
    {
    }

    public Pessoa(string? nome, int idade, string? genero)
    {
        Nome = nome;
        Idade = idade;
        Genero = genero;
    }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public void Identificar()
    {
        Console.WriteLine($"Olá, me chamo {Nome}, " +
            $"tenho {Idade} anos e sou do gênero {Genero}.");
    }
}
