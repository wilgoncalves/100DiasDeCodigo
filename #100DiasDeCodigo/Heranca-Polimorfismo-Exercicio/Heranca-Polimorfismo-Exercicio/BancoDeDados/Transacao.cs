namespace Heranca_Polimorfismo_Exercicio.BancoDeDados;

class Transacao : ConectarBancoDados, ITransacao, IRelatorio
{
    public void Executar()
    {
        Console.WriteLine("Processando transação.");
    }

    public void Imprimir()
    {
        Console.WriteLine("Imprimindo relatório.");
    }
}
