namespace UML_Composicao;

internal class Departamento : IDisposable
{
    private string _nome;
    private Escola Escola;

    internal Departamento(string nome, Escola escola)
    {
        _nome = nome;
        Escola = escola;
    }

    public void Dispose()
    {

    }
}
