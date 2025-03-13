using _17DiasDeCodigo.Entities.Enums;

namespace _17DiasDeCodigo.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        // Toda subclasse que herda de uma classe que possui métodos abstratos precisa implementá-los.
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
