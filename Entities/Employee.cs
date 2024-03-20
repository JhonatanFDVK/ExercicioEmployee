using System.Text;
using System.Globalization;

namespace ExercicioPolimorfismo01.Entities
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
