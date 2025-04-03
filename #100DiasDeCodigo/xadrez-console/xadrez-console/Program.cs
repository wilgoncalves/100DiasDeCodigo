using tabuleiro;
using xadrez;

try
{ 
    PartidaDeXadrez partida = new PartidaDeXadrez();

    Tela.ImprimirTabuleiro(partida.Tab!);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();