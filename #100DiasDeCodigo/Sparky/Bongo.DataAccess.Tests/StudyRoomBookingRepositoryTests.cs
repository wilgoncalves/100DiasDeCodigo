using Bongo.DataAccess.Repository;
using Bongo.Models.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Bongo.DataAccess
{
    [TestFixture]
    public class StudyRoomBookingRepositoryTests
    {
        private StudyRoomBooking _studyRoomBooking_One;
        private StudyRoomBooking _studyRoomBooking_Two;

        public StudyRoomBookingRepositoryTests()
        {
            _studyRoomBooking_One = new StudyRoomBooking()
            {
                FirstName = "Ben1",
                LastName = "Spark1",
                Date = new DateTime(2025, 1, 1),
                Email = "ben1@gmail.com",
                BookingId = 11,
                StudyRoomId = 1
            };

            _studyRoomBooking_Two = new StudyRoomBooking()
            {
                FirstName = "Ben2",
                LastName = "Spark2",
                Date = new DateTime(2025, 2, 2),
                Email = "ben2@gmail.com",
                BookingId = 22,
                StudyRoomId = 2
            };
        }

        [Test]
        public void SaveBooking_Booking_One_CheckTheValuesFromDatabase()
        {
            // arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_Bongo").Options;

            //act
            using (var context = new ApplicationDbContext(options))
            {
                var repository = new StudyRoomBookingRepository(context);
                repository.Book(_studyRoomBooking_One);
            }

            //assert
            using (var context = new ApplicationDbContext(options))
            {
                var bookingFromDb = context.StudyRoomBookings
                    .FirstOrDefault(u => u.BookingId == 11);

                ClassicAssert.AreEqual(_studyRoomBooking_One.BookingId, bookingFromDb!.BookingId);
                ClassicAssert.AreEqual(_studyRoomBooking_One.FirstName, bookingFromDb!.FirstName);
                ClassicAssert.AreEqual(_studyRoomBooking_One.LastName, bookingFromDb!.LastName);
                ClassicAssert.AreEqual(_studyRoomBooking_One.Email, bookingFromDb!.Email);
                ClassicAssert.AreEqual(_studyRoomBooking_One.Date, bookingFromDb!.Date);
            }
        }
    }
}
