namespace Heranca_Polimorfismo_Exercicio.Animal;

abstract class Animal
{
    public string? Tipo { get; set; }

    public Animal(string tipo)
    {
        Tipo = tipo;
    }

    public abstract void Mover();
}
