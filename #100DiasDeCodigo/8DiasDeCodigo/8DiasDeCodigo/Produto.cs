// Encapsulamento

using System.Globalization;

namespace _8DiasDeCodigo
{
    internal class Produto
    {
        // Encapsulamento - por padrão, usa-se "_"(underline) antes do nome do atributo.
        //private string? _nome;
        //private double _preco;
        //private int _quantidade;

        private string? _nome;
        // Usando auto properties:
        public double Preco {  get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Usamos os métodos GET e SET para acessar e modificar os atributos privados.

        //Como usar:
        //public string GetNome()
        //{
        //    return _nome!;
        //}

        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        // Simplificando - properties:

        public string Nome
        {
            get { return _nome!; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //public double Preco
        //{
        //    get { return _preco; }
        //}

        //public int Quantidade
        //{
        //    get { return Quantidade; }
        //}
        // No entanto, o mais recomendado são as auto properties.

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
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
