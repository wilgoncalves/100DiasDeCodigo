namespace CursoFoop_Solid_Exercicio_5
{
    public class PizzaFactory
    {
        public Pizza CriarPizza(string tipo)
        {
            Pizza pizza = null;

            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela("mussarela");
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa("calabresa");
            }

            return pizza;
        }
    }
}
