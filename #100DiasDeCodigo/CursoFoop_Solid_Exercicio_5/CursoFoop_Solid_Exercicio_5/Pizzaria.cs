namespace CursoFoop_Solid_Exercicio_5
{
    class Pizzaria
    {
        private Pizza _pizza;
        private PizzaFactory _factory;

        public Pizzaria(PizzaFactory factory)
        {
            _factory = factory;
        }

        public void CriarPizza(string tipo)
        {
            _pizza = _factory.CriarPizza(tipo);
            _pizza.AssarPizza();
            _pizza.DeliveryPizza();
        }
    }
}
