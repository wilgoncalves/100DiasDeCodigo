namespace Liskov_Substitution;

public class Funcionario
{
    private string? _name { get; set; }
    private string? _cargo { get; set; }

    public Funcionario(string name, string cargo)
    {
        _name = name;
        _cargo = cargo;
    }

    // movemos o método CalcularSalario para a classe base:
    public virtual double CalcularSalario(double salario)
    {
        return salario;
    }
}
