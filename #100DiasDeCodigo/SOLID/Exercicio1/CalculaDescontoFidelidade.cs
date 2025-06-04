using Exercicio1.Interfaces;

namespace Exercicio1;

public class CalculaDescontoFidelidade : ICalcularDescontoFidelidade
{
    public decimal AplicarDescontoFidelidade(decimal precoProduto, int tempoDeContaEmAnos)
    {
        decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE)
            ? (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100
            : (decimal)tempoDeContaEmAnos / 100;

        return precoProduto - (descontoPorFidelidade * precoProduto);
    }
}
