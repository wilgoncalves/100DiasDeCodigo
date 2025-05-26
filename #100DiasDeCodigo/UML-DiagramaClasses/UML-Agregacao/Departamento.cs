namespace UML_Agregacao;

internal class Departamento : IDisposable
{
    public string? Nome { get; set; }
    public List<Professor>? professores { get; set; }

    public void Dispose()
    {

    }
}
