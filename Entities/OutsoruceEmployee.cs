namespace ExercicioPolimorfismo01.Entities
{
    internal class OutsoruceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsoruceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 110 * AdditionalCharge / 100;
        }
    }
}
