using System.Globalization;

namespace _7DiasDeCodigo
{
    internal class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        // Princípio de sobrecarga:
        public Produto()
        {

        }

        // Com o intuito de evitar a existência de produtos sem nome e sem preço, é possível
        // fazer com que seja “obrigatória” a iniciação desses valores por meio dos construtores.
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Princípio de sobrecarga:
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // é possível iniciar o atributo com qualquer valor.
        }

        public double ValorTotalEmEstoque()
        {
            return Preco* Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
