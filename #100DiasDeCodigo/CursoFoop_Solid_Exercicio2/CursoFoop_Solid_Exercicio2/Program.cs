using System;

namespace CursoFoop_Solid_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger meuLogArquivo = new FileLogger();
            ILogger meuLogConsole = new ConsoleLogger();

            Pedido pedido1 = new Pedido(meuLogConsole);
            pedido1.AdicionarPedido();

            Pedido pedido2 = new Pedido(meuLogArquivo);
            pedido2.AdicionarPedido();

            Console.ReadLine();
        }
    }
}
