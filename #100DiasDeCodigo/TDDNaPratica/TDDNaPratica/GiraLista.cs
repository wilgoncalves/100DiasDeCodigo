namespace TDDNaPratica;

public class GiraLista
{
    public List<int> Girar(List<int> lista)
    {
        var item1 = lista[0];
        var novaLista = new List<int>();
        lista.RemoveAt(0);
        novaLista.AddRange(lista);
        novaLista.Add(item1);

        return novaLista;
    }
}
