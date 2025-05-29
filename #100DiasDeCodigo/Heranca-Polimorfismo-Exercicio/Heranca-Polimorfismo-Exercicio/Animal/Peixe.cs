namespace Heranca_Polimorfismo_Exercicio.Animal;

class Peixe : Animal
{
    public Peixe(string tipo) : base(tipo)
    {
    }

    public override void Mover()
    {
        Console.WriteLine($"{Tipo} está nadando.");
    }
}
