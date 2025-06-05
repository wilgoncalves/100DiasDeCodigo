using Exercicio1.Entities;
using Exercicio1.Enums;
using Exercicio1.Interfaces;

namespace Exercicio1;

public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
{
    public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
    {
        ICalculaDescontoStatusConta calcular;

        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                calcular = new ClienteNaoRegistrado();
                break;

            case StatusContaCliente.ClienteComum:
                calcular = new ClienteComum();
                break;

            case StatusContaCliente.ClienteEspecial:
                calcular = new ClienteEspecial();
                break;

            case StatusContaCliente.ClienteVip:
                calcular = new ClienteVip();
                break;

            default:
                throw new NotImplementedException();
        }
        return calcular;
    }
}
