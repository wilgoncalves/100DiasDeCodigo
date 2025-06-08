namespace Principios_SOLID_Exercicios;

public abstract class Produto(IPromocao promocao)
{
    public string? Nome { get; set; }
    public double Valor { get; set; }
    protected IPromocao _promocao = promocao;

    public double AplicarDescontoPromocao()
    {
        return _promocao.AplicarDesconto();
    }

    public double ValorVenda()
    {
        return Valor - (Valor * AplicarDescontoPromocao());
    }
}
