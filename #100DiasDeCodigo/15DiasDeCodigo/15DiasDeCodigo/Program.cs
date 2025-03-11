// Polimorfismo: é o recurso que permite que variáveis de um mesmo tipo mais genérico
// possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos
// diferentes conforme cada tipo específico.

using _15DiasDeCodigo.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int employees = int.Parse(Console.ReadLine()!);

List<Employee> list = new List<Employee>();

for (int i = 1; i <= employees; i++)
{
    Console.WriteLine($"Employee #{i} data:");

    Console.Write("Outsourced (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine()!);

    Console.Write("Name: ");
    string name = Console.ReadLine()!;

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine()!);

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (outsourced == 'y')
    {
        Console.Write("Additional charge: ");
        double addCharge = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}

// Execução polimórfica:
Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach (Employee emp in list)
{
    Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}

