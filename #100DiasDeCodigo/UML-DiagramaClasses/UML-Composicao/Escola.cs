namespace UML_Composicao;

internal class Escola : IDisposable
{
    public string? Nome { get; set; }
    private List<Departamento> _departamentos = new List<Departamento>();

    public void AddDepartamento(string nome)
    {
        _departamentos.Add(new Departamento(nome, this));
    }

    public void Dispose()
    {
        foreach (var departamento in _departamentos)
        {
            departamento.Dispose();
        }
    }
}
