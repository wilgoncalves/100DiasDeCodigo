using Exercicio1.Entities;
using Exercicio1.Enums;
using Exercicio1.Interfaces;

namespace Exercicio1;

public class GerenciadorDeDescontos(ICalcularDescontoFidelidade descontoFidelidade)
{
    private readonly ICalcularDescontoFidelidade _descontoFidelidade = descontoFidelidade;

    public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
        decimal precoAposDesconto = 0;
        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                precoAposDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(precoProduto);
                break;

            case StatusContaCliente.ClienteComum:
                precoAposDesconto = new ClienteComum().AplicarDescontoStatusConta(precoProduto);
                precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                break;

            case StatusContaCliente.ClienteEspecial:
                precoAposDesconto = new ClienteEspecial().AplicarDescontoStatusConta(precoProduto);
                precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                break;

            case StatusContaCliente.ClienteVip:
                precoAposDesconto = new ClienteVip().AplicarDescontoStatusConta(precoProduto);
                precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoProduto, tempoDeContaEmAnos);
                break;

            default:
                throw new NotImplementedException();
        }
        return precoAposDesconto;
    }
}
