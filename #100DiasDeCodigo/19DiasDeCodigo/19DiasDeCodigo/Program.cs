﻿// Criando exceções personalizadas

using _19DiasDeCodigo.Entities;
using _19DiasDeCodigo.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine()!);
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine()!);

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine($"Reservation: {reservation}");

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine()!);

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine($"Reservation: {reservation}");
}
catch (DomainException e)
{
    Console.WriteLine($"Error in reservation: {e.Message}");
}
catch (FormatException e)
{
    Console.WriteLine($"Format error: {e.Message}");
}
// Exceção genérica para capturar erros não previstos.
catch (Exception e)
{
    Console.WriteLine($"Unexpected error: {e.Message}");
}
