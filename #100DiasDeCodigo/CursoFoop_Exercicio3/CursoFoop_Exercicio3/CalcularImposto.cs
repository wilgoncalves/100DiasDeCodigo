namespace CursoFoop_Exercicio3
{
    class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais calcularImposto)
        {
            return calcularImposto.CalcularValorImposto();
        }
    }
}
