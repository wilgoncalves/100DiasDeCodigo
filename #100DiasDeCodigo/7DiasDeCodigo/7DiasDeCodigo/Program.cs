using _7DiasDeCodigo;
using System.Globalization;

namespace _7DiasDeCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            // Com o princípio de sobrecarga, é possível omitir a entrada de valor de um dos atributos.
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine()!);
            // Produto p = new(nome, preco, quantidade);

            // Princípio de sobrecarga:
            Produto p = new(nome, preco);
            Produto p2 = new Produto();

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
