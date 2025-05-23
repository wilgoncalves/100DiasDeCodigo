namespace Heranca;

public class Conta
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public virtual void GetSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }
}
