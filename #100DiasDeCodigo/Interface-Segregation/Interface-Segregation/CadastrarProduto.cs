namespace Interface_Segregation;

internal class CadastrarProduto : IPersistencia
{
    /* A implementação da interface na classe viola o princípio
    da segregação de interface, pois não necessita do uso de todos 
    os métodos da interface, para isso cria-se a interface IMensagemEmail. */
    //public void EnviarEmail()
    //{
    //    throw new NotImplementedException();
    //}

    public void SalvarDataBase()
    {
        Console.WriteLine("Salva dados.");
    }

    public void ValidarDados()
    {
        Console.WriteLine("Valida dados.");
    }
}
