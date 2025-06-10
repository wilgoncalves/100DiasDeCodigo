using NUnit.Framework.Legacy;
using TDDNaPratica;

namespace TDDNaPraticaNUnitTest;

[TestFixture]
public class GiraListaNUnitTests
{
    [TestCase]
    public void DeveMoverOPrimeiroItemParaOFinalDaListaDe4Itens()
    {
        var lista = new List<int> { 10, 15, 20, 30 };
        var gira = new GiraLista();

        var novaLista = gira.Girar(lista);

        Assert.That(4, Is.EqualTo(novaLista.Count));
        Assert.That(15, Is.EqualTo(novaLista[0]));
        Assert.That(10, Is.EqualTo(novaLista[3]));
    }

    [TestCase]
    public void DeveMoverOPrimeiroItemParaOFinalDaListaDe3Itens()
    {
        var lista = new List<int> { 12, 15, 25 };
        var gira = new GiraLista();

        var novaLista = gira.Girar(lista);

        Assert.That(3, Is.EqualTo(novaLista.Count));
        Assert.That(15, Is.EqualTo(novaLista[0]));
        Assert.That(12, Is.EqualTo(novaLista[2]));
    }

    [TestCase]
    public void DeveMoverOPrimeiroItemParaOFinalDaListaDe5Itens()
    {
        var lista = new List<int> { 1, 32, 15, 29, 55 };
        var gira = new GiraLista();

        var novaLista = gira.Girar(lista);

        Assert.That(5, Is.EqualTo(novaLista.Count));
        Assert.That(32, Is.EqualTo(novaLista[0]));
        Assert.That(1, Is.EqualTo(novaLista[4]));
    }
}
