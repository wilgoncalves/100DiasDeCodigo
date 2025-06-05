using Exercicio1.Enums;
using Exercicio1.Interfaces;

namespace Exercicio1;

public class GerenciadorDeDescontos(ICalcularDescontoFidelidade descontoFidelidade, 
    ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
{
    private readonly ICalcularDescontoFidelidade _descontoFidelidade = descontoFidelidade;
    private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;

    public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
        decimal precoAposDesconto = 0;

        precoAposDesconto = _calculaDescontoStatusContaFactory
            .GetCalculoDescontoStatusConta(statusContaCliente)
            .AplicarDescontoStatusConta(precoProduto);

        precoAposDesconto = _descontoFidelidade
            .AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

        return precoAposDesconto;
    }
}
