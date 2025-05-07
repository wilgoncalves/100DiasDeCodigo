using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace Sparky
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator? _gradingCalculator;

        [SetUp]
        public void SetUp()
        {
            _gradingCalculator = new GradingCalculator();
        }

        [Test]
        public void GetGrade_InputScore95AndAttendance90_ReturnsAGrade()
        {
            _gradingCalculator!.Score = 95;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            ClassicAssert.That(result, Is.EqualTo("A"));
        }

        [Test]
        public void GetGrade_InputScore85AndAttendance90_ReturnsBGrade()
        {
            _gradingCalculator!.Score = 85;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            ClassicAssert.That(result, Is.EqualTo("B"));
        }

        [Test]
        public void GetGrade_InputScore65AndAttendance90_ReturnsCGrade()
        {
            _gradingCalculator!.Score = 65;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            ClassicAssert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void GetGrade_InputScore95AndAttendance65_ReturnsBGrade()
        {
            _gradingCalculator!.Score = 95;
            _gradingCalculator.AttendancePercentage = 65;

            string result = _gradingCalculator.GetGrade();

            ClassicAssert.That(result, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(95, 55)]
        [TestCase(65, 55)]
        [TestCase(50, 90)]
        public void GetGrade_ScoreBelow60AndAttendanceBelow60_ReturnsFGrade(int score, int attendance)
        {
            _gradingCalculator!.Score = score;
            _gradingCalculator.AttendancePercentage = attendance;

            string result = _gradingCalculator.GetGrade();

            ClassicAssert.That(result, Is.EqualTo("F"));
        }
    }
}
