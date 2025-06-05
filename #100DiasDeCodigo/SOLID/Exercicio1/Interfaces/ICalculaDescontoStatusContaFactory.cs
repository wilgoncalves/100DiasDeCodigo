using Exercicio1.Enums;

namespace Exercicio1.Interfaces;

public interface ICalculaDescontoStatusContaFactory
{
    ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
}
