namespace Interface_Segregation;

interface IPersistencia
{
    void ValidarDados();

    void SalvarDataBase();

    /* a interface precisa ser o mais específica possível,
    por isso, o método EnviarEmail() deve ser movido para
    uma nova interface */
    //void EnviarEmail();
}
