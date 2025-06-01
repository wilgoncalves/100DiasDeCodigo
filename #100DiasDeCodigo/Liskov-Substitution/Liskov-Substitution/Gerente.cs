namespace Liskov_Substitution;

public class Gerente : Funcionario
{
    private double _bonus = 3000;

    public Gerente(string name, string cargo) : base(name, cargo)
    {
    }

    /* Violação do princípio LSP, a classe base Funcionario
    não acessa método da classe derivada. */
    //public double CalcularSalario(double salario)
    //{
    //    return salario + _bonus;
    //}

    public override double CalcularSalario(double salario)
    {
        return salario + _bonus;
    }
}
