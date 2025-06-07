using System;

namespace CursoFoop_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalcularImpostoPais calc = new CalcularImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            CalcularImposto calcularImposto = new CalcularImposto();
            var valorTotalImposto = calcularImposto.Calcular(calc);
            Console.WriteLine($"Brasil: {valorTotalImposto}");
        }
    }
}
