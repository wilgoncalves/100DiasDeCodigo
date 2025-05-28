namespace ClassesAbstratas_Interfaces;

abstract class Figura
{
    public string? Nome { get; set; }

    public Figura(string nome)
    {
        Nome = nome;
    }

    public abstract void Desenhar();

    public abstract void Identificar();

    protected void Duplicar()
    {
        Console.WriteLine("Duplicando a figura.");
    }
}
