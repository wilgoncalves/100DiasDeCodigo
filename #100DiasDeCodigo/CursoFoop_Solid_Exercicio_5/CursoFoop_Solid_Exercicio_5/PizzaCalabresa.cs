using System;

namespace CursoFoop_Solid_Exercicio_5
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        {
        }

        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}
