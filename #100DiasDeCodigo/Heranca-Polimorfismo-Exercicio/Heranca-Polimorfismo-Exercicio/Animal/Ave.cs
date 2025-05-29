namespace Heranca_Polimorfismo_Exercicio.Animal;

class Ave : Animal
{
    public Ave(string tipo) : base(tipo)
    {
    }

    public override void Mover()
    {
        Console.WriteLine($"{Tipo} está voando.");
    }
}
