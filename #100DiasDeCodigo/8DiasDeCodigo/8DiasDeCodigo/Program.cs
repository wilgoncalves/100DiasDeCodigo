// Encapsulamento

using _8DiasDeCodigo;
using System.Globalization;

namespace _8DiasDeCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            // Utilizando o método imlementado SET:
            // p.SetNome("T");

            // Utilizando uma property:
            p.Nome = "TV 4K";

            // Console.WriteLine(p.GetNome());
            // Console.WriteLine(p.GetQuantidade());
            
            // Utilizando auto properties:
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}
