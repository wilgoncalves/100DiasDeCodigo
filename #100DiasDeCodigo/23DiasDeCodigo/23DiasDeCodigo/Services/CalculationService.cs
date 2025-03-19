// Restrições de Generics

namespace _23DiasDeCodigo.Services
{
    internal class CalculationService
    {
        // Restrigindo o tipo T com IComparable
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                // Fazendo comparação da forma genérica.
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
