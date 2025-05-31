namespace Open_Closed_Principle;

public class Produto
{
    public int ProductId { get; private set; }
    public string? Nome { get; private set; }
    public string? Descricao { get; private set; }
    public int Estoque { get; private set; }
    public bool Ativo { get; private set; }

    private decimal _custo = 0;
    public decimal Custo
    {
        get => _custo;

        private set
        {
            if (value > 0)
                _custo = value;
        }
    }

    private decimal _venda = 1;
    public decimal Venda
    {
        get => _venda;

        private set
        {
            if (value > 0)
                _venda = value;
        }
    }

    public Produto(int productId, string? nome, string? descricao, int estoque, 
        bool ativo, decimal custo, decimal venda)
    {
        ProductId = productId;
        Nome = nome;
        Descricao = descricao;
        Estoque = estoque;
        Ativo = ativo;
        Custo = custo;
        Venda = venda;
    }

    /* adicionar novo código a uma classe existente viola
    o conceito OCP (Open-CLosed Principle) */

    //public double MargemLucro()
    //{
    //    try
    //    {
    //        var lucroLiquido = Venda - Custo;
    //        var margemLucro = (lucroLiquido / Venda) * 100;
    //        return Convert.ToDouble(margemLucro);
    //    }
    //    catch
    //    {
    //        throw new InvalidOperationException("Erro ao calcular margem de lucro");
    //    }
    //}
}
