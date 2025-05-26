namespace UML_Heranca;

internal class ContaCorrente : Conta
{
    public double Limite { get; set; }

    public double DescontoJuros(double valorDesconto)
    {
        return Saldo - valorDesconto;
    }
}
