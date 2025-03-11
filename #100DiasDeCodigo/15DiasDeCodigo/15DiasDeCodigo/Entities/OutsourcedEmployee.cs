// Polimorfismo

namespace _15DiasDeCodigo.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCHarge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCHarge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCHarge = additionalCHarge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCHarge;
        }
    }
}
