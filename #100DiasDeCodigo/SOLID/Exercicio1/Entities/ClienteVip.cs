using Exercicio1.Interfaces;

namespace Exercicio1.Entities;

public class ClienteVip : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal precoProduto)
    {
        return precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto);
    }
}
