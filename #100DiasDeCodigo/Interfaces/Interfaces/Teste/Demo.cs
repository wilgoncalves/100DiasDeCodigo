namespace Interfaces.Teste;

// uma classe pode herdar mais de uma interface
internal class Demo : IControle, ITeste
{
    public void Desenhar()
    {
        throw new NotImplementedException();
    }

    public void Pintar()
    {
        throw new NotImplementedException();
    }
}
