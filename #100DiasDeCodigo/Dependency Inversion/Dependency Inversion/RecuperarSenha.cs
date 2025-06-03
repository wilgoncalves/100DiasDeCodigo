namespace Dependency_Inversion;

class RecuperarSenha
{
    /* violação do principio da inversão de dependência,
    classe possui alto acoplamento com MySqlConnection */
    //private MySqlConnection _conexaoBanco;

    //public RecuperarSenha()
    //{
    //    _conexaoBanco = new MySqlConnection();
    //}

    // Maneira correta - gerando injeção de dependência com a interface criada:
    private IDataBaseConnection _connection;

    public RecuperarSenha(IDataBaseConnection connection)
    {
        _connection = connection;
    }
}

