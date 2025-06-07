namespace CursoFoop_Exercicio3
{
    public class CalcularImpostoArgentina : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 40 / 100;
        }
    }
}
