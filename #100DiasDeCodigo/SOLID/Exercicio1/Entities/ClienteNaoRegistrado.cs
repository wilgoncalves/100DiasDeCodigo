using Exercicio1.Interfaces;

namespace Exercicio1.Entities;

public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal precoProduto)
    {
        return precoProduto;
    }
}
