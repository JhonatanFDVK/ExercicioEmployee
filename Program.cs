using ExercicioPolimorfismo01.Entities;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();

        Console.Write("Enter the number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());

        Employee employee;

        for (int i = 0; i < numberEmployees; i++)
        {
            Console.WriteLine($"Employee #{i + 1} data:");
            Console.Write("Outsourced (y/n)? ");
            string response = Console.ReadLine();

            if (response == "n" || response == "N")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee = new Employee(name, hours, valuePerHour);
                list.Add(employee);
            }
            if (response == "y" || response == "Y")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee = new OutsoruceEmployee(name, hours, valuePerHour, additionalCharge);
                list.Add(employee);
            }
        }

        Console.WriteLine("\nPAYMENTS:");

        foreach (Employee item in list)
        {
            Console.WriteLine(item);
        }
    }
}