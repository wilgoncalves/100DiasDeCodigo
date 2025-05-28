namespace Polimorfismo;

class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo.");
        base.Desenhar();
    }
}
