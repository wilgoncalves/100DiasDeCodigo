namespace Desacoplamento;

class RegistrarNoConsole : IRegistro
{
    public void RegistrarInfo(string mensagem)
    {
        Console.WriteLine($"Info : {mensagem}");
    }
}
