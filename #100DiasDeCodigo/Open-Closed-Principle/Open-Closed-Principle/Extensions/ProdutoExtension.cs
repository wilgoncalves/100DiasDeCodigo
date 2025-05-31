namespace Open_Closed_Principle.Extensions;

public static class ProdutoExtension
{
    public static double MargemLucro(this Produto produto)
    {
        try
        {
            var lucroLiquido = produto.Venda - produto.Custo;
            var margemLucro = (lucroLiquido / produto.Venda) * 100;
            return Convert.ToDouble(margemLucro);
        }
        catch
        {
            throw new InvalidOperationException("Erro ao calcular margem de lucro");
        }
    }
}
