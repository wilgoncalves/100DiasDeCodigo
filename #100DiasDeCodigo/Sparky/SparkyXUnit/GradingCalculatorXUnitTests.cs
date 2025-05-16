using Xunit;

namespace Sparky
{
    public class GradingCalculatorXUnitTests
    {
        private GradingCalculator? _gradingCalculator;

        public GradingCalculatorXUnitTests()
        {
            _gradingCalculator = new GradingCalculator();
        }

        [Fact]
        public void GetGrade_InputScore95AndAttendance90_ReturnsAGrade()
        {
            _gradingCalculator!.Score = 95;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            Assert.Equal("A", result);
        }

        [Fact]
        public void GetGrade_InputScore85AndAttendance90_ReturnsBGrade()
        {
            _gradingCalculator!.Score = 85;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            Assert.Equal("B", result);
        }

        [Fact]
        public void GetGrade_InputScore65AndAttendance90_ReturnsCGrade()
        {
            _gradingCalculator!.Score = 65;
            _gradingCalculator.AttendancePercentage = 90;

            string result = _gradingCalculator.GetGrade();

            Assert.Equal("C", result);
        }

        [Fact]
        public void GetGrade_InputScore95AndAttendance65_ReturnsBGrade()
        {
            _gradingCalculator!.Score = 95;
            _gradingCalculator.AttendancePercentage = 65;

            string result = _gradingCalculator.GetGrade();

            Assert.Equal("B", result);
        }

        [Theory]
        [InlineData(95, 55)]
        [InlineData(65, 55)]
        [InlineData(50, 90)]
        public void GetGrade_ScoreBelow60AndAttendanceBelow60_ReturnsFGrade(int score, int attendance)
        {
            _gradingCalculator!.Score = score;
            _gradingCalculator.AttendancePercentage = attendance;

            string result = _gradingCalculator.GetGrade();

            Assert.Equal("F", result);
        }

        [Theory]
        [InlineData(95, 90, "A")]
        [InlineData(85, 90, "B")]
        [InlineData(65, 90, "C")]
        [InlineData(95, 65, "B")]
        [InlineData(95, 55, "F")]
        [InlineData(65, 55, "F")]
        [InlineData(50, 90, "F")]
        public void GetGrade_InputTwoIntNumbers_ReturnsCorrectGrade(int score, int attendance, string expectedResult)
        {
            _gradingCalculator!.Score = score;
            _gradingCalculator.AttendancePercentage = attendance;

            var result = _gradingCalculator.GetGrade();

            Assert.Equal(expectedResult, result);
        }
    }
}
