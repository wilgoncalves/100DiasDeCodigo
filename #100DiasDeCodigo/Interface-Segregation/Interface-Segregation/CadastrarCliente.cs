namespace Interface_Segregation;

internal class CadastrarCliente : IPersistencia, IMensagemEMail
{
    public void EnviarEmail()
    {
        Console.WriteLine("Envia email.");
    }

    public void SalvarDataBase()
    {
        Console.WriteLine("Salva dados.");
    }

    public void ValidarDados()
    {
        Console.WriteLine("Valida dados.");
    }
}
