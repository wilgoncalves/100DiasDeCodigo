namespace Liskov_Substitution;

public class Vendedor : Funcionario
{
    public double Comissao = 1500;

    public Vendedor(string name, string cargo) : base(name, cargo)
    {
    }

    /* Violação do princípio LSP, a classe base Funcionario
    não acessa método da classe derivada. */
    //public double CalcularSalario(double salario)
    //{
    //    return salario + Comissao;
    //}

    public override double CalcularSalario(double salario)
    {
        return salario + Comissao;
    }
}
