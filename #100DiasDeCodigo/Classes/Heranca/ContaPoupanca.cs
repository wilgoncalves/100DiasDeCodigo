namespace Heranca;

public class ContaPoupanca : Conta
{
    public int JurosMensais { get; set; }

    //Sobrescrevendo um método
    public override void GetSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo * 2.0}");
    }
}
