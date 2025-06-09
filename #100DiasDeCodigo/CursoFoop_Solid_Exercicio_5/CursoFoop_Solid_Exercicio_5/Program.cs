using System;

namespace CursoFoop_Solid_Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaria pizza1 = new Pizzaria(new PizzaFactory());
            pizza1.CriarPizza("mussarela");
            pizza1.CriarPizza("calabresa");
        }
    }
}
