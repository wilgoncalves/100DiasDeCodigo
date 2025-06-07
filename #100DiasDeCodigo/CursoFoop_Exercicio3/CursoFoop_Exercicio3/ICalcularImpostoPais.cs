namespace CursoFoop_Exercicio3
{
    public interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }

        decimal CalcularValorImposto();
    }
}
