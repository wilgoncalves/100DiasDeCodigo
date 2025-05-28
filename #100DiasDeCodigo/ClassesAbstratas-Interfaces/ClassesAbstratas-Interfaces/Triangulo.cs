namespace ClassesAbstratas_Interfaces;

internal class Triangulo : IFigura
{
    public string? Nome { get; set; }

    public Triangulo(string nome)
    {
        Nome = nome;
    }

    public void Desenhar()
    {
        Console.WriteLine($"Desenhando {Nome}...");
    }

    public void Duplicar()
    {
        Console.WriteLine("Duplicando a figura.");
    }

    public void Identificar()
    {
        Console.WriteLine($"Sou o {Nome}...");
    }
}
