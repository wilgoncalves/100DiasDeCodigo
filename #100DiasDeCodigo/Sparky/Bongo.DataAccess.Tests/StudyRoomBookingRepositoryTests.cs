using Bongo.DataAccess.Repository;
using Bongo.Models.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections;

namespace Bongo.DataAccess
{
    [TestFixture]
    public class StudyRoomBookingRepositoryTests
    {
        private StudyRoomBooking _studyRoomBooking_One;
        private StudyRoomBooking _studyRoomBooking_Two;
        private DbContextOptions<ApplicationDbContext>? _contextOptions;

        [SetUp]
        public void SetUp()
        {
            _contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_Bongo").Options;
        }

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
        [Order(1)]
        public void SaveBooking_Booking_One_CheckTheValuesFromDatabase()
        {
            //act
            using (var context = new ApplicationDbContext(_contextOptions))
            {
                var repository = new StudyRoomBookingRepository(context);
                repository.Book(_studyRoomBooking_One);
            }

            //assert
            using (var context = new ApplicationDbContext(_contextOptions))
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

        [Test]
        [Order(2)]
        public void GetAllBooking_Booking_OneAndTwo_CheckBothTheBookingFromDatabase()
        {
            // arrange
            var expectedResult = new List<StudyRoomBooking> 
            {
                _studyRoomBooking_One, 
                _studyRoomBooking_Two 
            };

            using (var context = new ApplicationDbContext(_contextOptions))
            {
                context.Database.EnsureDeleted();
                var repository = new StudyRoomBookingRepository(context);
                repository.Book(_studyRoomBooking_One);
                repository.Book(_studyRoomBooking_Two);
            }

            //act
            List<StudyRoomBooking> actualList;
            using (var context = new ApplicationDbContext(_contextOptions))
            {
                var repository = new StudyRoomBookingRepository(context);
                actualList = repository.GetAll(null).ToList();
            }

            //assert
            CollectionAssert.AreEqual(expectedResult, actualList, new BookingCompare());
        }

        private class BookingCompare : IComparer
        {
            public int Compare(object? x, object? y)
            {
                var booking1 = (StudyRoomBooking)x!;
                var booking2 = (StudyRoomBooking)y!;

                if (booking1.BookingId != booking2.BookingId)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
