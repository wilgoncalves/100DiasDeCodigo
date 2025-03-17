// Interfaces
// É um tipo que define um conjunto de operações que uma classe
// ou struct deve implementar. A interface estabelece um contrato
// que a classe deve cumprir.
using _21DiasDeCodigo.Entities;
using _21DiasDeCodigo.Services;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine()!;
Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy HH:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);