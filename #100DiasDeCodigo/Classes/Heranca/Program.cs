using Heranca;
using System.Net.WebSockets;
using System.Runtime.Intrinsics.X86;

//Classe filho herda atributos e métodos de classe pai
ContaPoupanca contaPoupanca = new ContaPoupanca();

contaPoupanca.Numero = 100;
contaPoupanca.Saldo = 99.99;
contaPoupanca.GetSaldo();
Console.WriteLine();

//// -------------------------------------------------

//// Upcasting e Downcasting:

//Upcasting();

//Downcasting();

//--------------------------------------

// Operador AS:
//Downcasting_AS();

// Operador IS:
Circulo circulo = new Circulo();
Forma f = circulo;

if (f is Circulo)
    ((Circulo)f).PintarCirculo();
else
    Console.WriteLine("A conversão não é possível.");


static void Upcasting()
{
    Circulo circulo = new Circulo();
    Forma f = circulo; //upcasting

    Console.WriteLine(f == circulo);
    f.Desenhar();
    Console.WriteLine();
}

static void Downcasting()
{
    Circulo circulo = new Circulo();
    Forma f = circulo;
    Circulo c = (Circulo)f; //downcasting

    Console.WriteLine(c == f);
    Console.WriteLine(c == circulo);
    c.Desenhar();
    c.PintarCirculo();
}

static void Downcasting_AS()
{
    Forma f1 = new Forma();
    Circulo? c1 = f1 as Circulo;

    if (c1 != null)
        c1.PintarCirculo();
    else
        Console.WriteLine("Operação inválida");
}

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