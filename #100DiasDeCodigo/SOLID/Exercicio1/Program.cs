using Exercicio1;
using Exercicio1.Enums;
using Exercicio1.Interfaces;

ICalcularDescontoFidelidade descontoFidelidade = new CalculaDescontoFidelidade();   
ICalculaDescontoStatusContaFactory descontoStatus = new CalculaDescontoStatusContaFactory();

GerenciadorDeDescontos gerenciadorDeDescontos = new GerenciadorDeDescontos(descontoFidelidade, descontoStatus);

Console.WriteLine("Valor da compra: R$1.000, fidelidade: 10 anos (5%)\n");
var result1 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteComum}, valor do desconto é: {result1}.");

var result2 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteEspecial}, valor do desconto é: {result2}.");

var result3 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 10);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteVip}, valor do desconto é: {result3}.");

Console.WriteLine("\n\nValor da compra: R$1.000, fidelidade: 4 anos (4%)\n");
var result4 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteComum}, valor do desconto é: {result4}.");

var result5 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteEspecial}, valor do desconto é: {result5}.");

var result6 = gerenciadorDeDescontos.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 4);
Console.WriteLine($"Cliente: {StatusContaCliente.ClienteVip}, valor do desconto é: {result6}.");
