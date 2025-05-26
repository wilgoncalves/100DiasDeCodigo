namespace UML_Heranca;

internal class ContaPoupanca : Conta
{
    public DateTime DataNascimento { get; set; }

    public double CreditoJuros(double valorJuros)
    {
        return Saldo + valorJuros;
    }
}
