using _19DiasDeCodigo.Entities.Exceptions;
// Criando exceções personalizadas

namespace _19DiasDeCodigo.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {   
            // Tratando exceções na classe.
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            // Tratamento de exceções
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update mustbe future dates.");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}," +
                $" check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.";
        }
    }
}
