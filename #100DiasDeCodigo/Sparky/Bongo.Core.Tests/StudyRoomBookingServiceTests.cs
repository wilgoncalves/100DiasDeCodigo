using Bongo.Core.Services;
using Bongo.DataAccess.Repository.IRepository;
using Bongo.Models.Model;
using Bongo.Models.Model.VM;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Bongo.Core
{
    [TestFixture]
    public class StudyRoomBookingServiceTests
    {
        private StudyRoomBooking? _request;
        private List<StudyRoom>? _availableStudyRoom;
        private Mock<IStudyRoomBookingRepository>? _studyRoomBookingRepoMock;
        private Mock<IStudyRoomRepository>? _studyRoomRepoMock;
        private StudyRoomBookingService? _studyRoomBookingService;

        [SetUp]
        public void SetUp()
        {
            _request = new StudyRoomBooking
            {
                FirstName = "Willian",
                LastName = "Gonçalves",
                Email = "wil@gmail.com",
                Date = new DateTime(2026, 1, 1)
            };

            _availableStudyRoom = new List<StudyRoom>
            {
                new StudyRoom
                {
                    Id = 10,
                    RoomNumber = "A202",
                    RoomName = "Michingan"
                }
            };

            _studyRoomBookingRepoMock = new Mock<IStudyRoomBookingRepository>();
            _studyRoomRepoMock = new Mock<IStudyRoomRepository>();
            _studyRoomRepoMock.Setup(x => x.GetAll()).Returns(_availableStudyRoom);
            _studyRoomBookingService = new StudyRoomBookingService(
                _studyRoomBookingRepoMock.Object, _studyRoomRepoMock.Object);
        }

        [TestCase]
        public void GetAllBooking_InvokeMethod_CheckIfRepoIsCalled()
        {
            _studyRoomBookingService!.GetAllBooking();
            _studyRoomBookingRepoMock!.Verify(x => x.GetAll(null), Times.Once);
        }

        [TestCase]
        public void BookingException_NullRequest_ThrowsException()
        {
            var exception = ClassicAssert.Throws<ArgumentNullException>(() =>
            _studyRoomBookingService!.BookStudyRoom(null))!;

            ClassicAssert.AreEqual("Value cannot be null. (Parameter 'request')",
                exception.Message);
            ClassicAssert.AreEqual("request", exception.ParamName);
        }

        [Test]
        public void StudyRoomBooking_SaveBookingWithAvailableRoom_ReturnsResultWithAllValues()
        {
            StudyRoomBooking savedStudyRoomBooking = null!;
            _studyRoomBookingRepoMock!.Setup(x => x.Book(It.IsAny<StudyRoomBooking>()))
                .Callback<StudyRoomBooking>(booking =>
                {
                    savedStudyRoomBooking = booking;
                });

            //act
            _studyRoomBookingService!.BookStudyRoom(_request);

            //assert
            _studyRoomBookingRepoMock.Verify(x => x.Book(It.IsAny<StudyRoomBooking>()), Times.Once);

            ClassicAssert.NotNull(savedStudyRoomBooking);
            ClassicAssert.AreEqual(_request!.FirstName, savedStudyRoomBooking.FirstName);
            ClassicAssert.AreEqual(_request!.LastName, savedStudyRoomBooking.LastName);
            ClassicAssert.AreEqual(_request!.Email, savedStudyRoomBooking.Email);
            ClassicAssert.AreEqual(_request!.Date, savedStudyRoomBooking.Date);
            ClassicAssert.AreEqual(_availableStudyRoom!.First().Id, savedStudyRoomBooking.StudyRoomId);
        }

        [Test]
        public void StudyRoomBookingResultCheck_InputRequest_ValuesMatchInResult()
        {
            StudyRoomBookingResult result = _studyRoomBookingService!.BookStudyRoom(_request);

            ClassicAssert.NotNull(result);
            ClassicAssert.AreEqual(_request!.FirstName, result.FirstName);
            ClassicAssert.AreEqual(_request!.LastName, result.LastName);
            ClassicAssert.AreEqual(_request!.Email, result.Email);
            ClassicAssert.AreEqual(_request!.Date, result.Date);
        }

        [TestCase(true, ExpectedResult = StudyRoomBookingCode.Success)]
        [TestCase(false, ExpectedResult = StudyRoomBookingCode.NoRoomAvailable)]
        public StudyRoomBookingCode ResultCodeSuccess_RoomAvailability_ReturnsSuccessResultCode(bool roomAvailability)
        {
            if (!roomAvailability)
                _availableStudyRoom!.Clear();

            return _studyRoomBookingService!.BookStudyRoom(_request).Code;
        }

        [TestCase(0, false)]
        [TestCase(55, true)]
        public void StudyRoomBooking_BookingRoomWithAvailability_ReturnsBookingId
            (int expectedBookingId, bool roomAvailability)
        {
            if (!roomAvailability)
                _availableStudyRoom!.Clear();

            _studyRoomBookingRepoMock!.Setup(x => x.Book(It.IsAny<StudyRoomBooking>()))
                .Callback<StudyRoomBooking>(booking =>
                {
                    booking.BookingId = 55;
                });

            var result = _studyRoomBookingService!.BookStudyRoom(_request);

            ClassicAssert.AreEqual(expectedBookingId, result.BookingId);
        }

        [Test]
        public void BookNotInvoked_SaveBookingWithoutAvailableRoom_BookMethodNotInvoked()
        {
            _availableStudyRoom!.Clear();

            var result = _studyRoomBookingService!.BookStudyRoom(_request);

            _studyRoomBookingRepoMock!.Verify(x => 
            x.Book(It.IsAny<StudyRoomBooking>()), Times.Never);
        }
    }
}

