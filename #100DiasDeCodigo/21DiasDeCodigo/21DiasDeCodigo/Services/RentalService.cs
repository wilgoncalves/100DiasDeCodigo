﻿// Interfaces
using _21DiasDeCodigo.Entities;

namespace _21DiasDeCodigo.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        
        private ITaxService? _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService? taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
            // Inversão de controle por meio de injeção de dependência
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            double tax = _taxService!.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
