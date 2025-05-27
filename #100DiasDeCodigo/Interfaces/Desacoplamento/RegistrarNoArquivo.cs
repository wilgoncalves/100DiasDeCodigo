namespace Desacoplamento;

class RegistrarNoArquivo(string path) : IRegistro
{
    private readonly string _caminhoNomeArquivo = path;

    public void RegistrarInfo(string mensagem)
    {
        Log(mensagem);
    }

    private void Log(string mensagem)
    {
        using var stremWriter = new StreamWriter(_caminhoNomeArquivo, true);
        stremWriter.WriteLine(mensagem);
    }
}
