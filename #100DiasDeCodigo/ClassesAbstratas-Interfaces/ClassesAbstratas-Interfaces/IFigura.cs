namespace ClassesAbstratas_Interfaces;

interface IFigura
{
    string Nome { get; set; }

    void Desenhar();
    void Identificar();
    void Duplicar();
}
