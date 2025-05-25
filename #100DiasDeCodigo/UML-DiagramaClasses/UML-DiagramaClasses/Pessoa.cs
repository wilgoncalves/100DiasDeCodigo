namespace UML_DiagramaClasses;

public class Pessoa
{
    public Pessoa()
    {
    }

    public Pessoa(string nome, int idade, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    private DateTime dataNascimento = new DateTime(1980, 9, 11);

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Sexo { get; set; }

    public void IdentificarPessoa()
    {
        Console.WriteLine($"{Nome} - {Idade} - {Sexo}");
    }
}
