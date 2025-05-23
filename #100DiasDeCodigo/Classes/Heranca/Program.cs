using Heranca;
using System.Net.WebSockets;

//Classe filho herda atributos e métodos de classe pai
ContaPoupanca contaPoupanca =  new ContaPoupanca();

contaPoupanca.Numero = 100;
contaPoupanca.Saldo = 99.99;
contaPoupanca.GetSaldo();
Console.WriteLine();

// -------------------------------------------------

// Upcasting e Downcasting:

Circulo circulo = new Circulo();
Forma f = circulo; //upcasting

Console.WriteLine(f == circulo);
f.Desenhar();
Console.WriteLine();
//--------------------------------------
Circulo c = (Circulo)f; //downcasting

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);
c.Desenhar();
c.PintarCirculo();

public class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Forma");
    }
}

public class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Forma");
    }

    public void PintarCirculo()
    {
        Console.WriteLine("Pintando o círculo");
    }
}