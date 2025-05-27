namespace Desacoplamento;

class RegistraOcorrencias(IRegistro registro)
{
    private readonly IRegistro _registro = registro;

    public void Registrar(string mensagem)
    {
        _registro.RegistrarInfo($"{mensagem} : {DateTime.Now}");
    }
}
