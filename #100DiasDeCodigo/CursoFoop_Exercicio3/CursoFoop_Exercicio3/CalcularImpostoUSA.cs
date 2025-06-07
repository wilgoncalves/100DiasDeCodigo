namespace CursoFoop_Exercicio3
{
    public class CalcularImpostoUSA : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 30 / 100;
        }
    }
}
