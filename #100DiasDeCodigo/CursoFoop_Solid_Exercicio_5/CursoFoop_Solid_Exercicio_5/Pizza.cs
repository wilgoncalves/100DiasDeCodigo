using System;

namespace CursoFoop_Solid_Exercicio_5
{
    public abstract class Pizza
    {
        protected Pizza(string nome)
        {
            Nome = nome;
        }

        public string? Nome { get; set; }

        public abstract int AssarPizza();

        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar pizza de {Nome}");
        }
    }
}
