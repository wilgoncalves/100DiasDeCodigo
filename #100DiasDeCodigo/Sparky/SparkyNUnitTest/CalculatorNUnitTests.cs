using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert
            ClassicAssert.AreEqual(30, result);
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOdd = calc.IsOddNumber(10);

            //Assert
            ClassicAssert.That(isOdd, Is.EqualTo(false));
            //OR:
            //ClassicAssert.IsFalse(isOdd);
        }

        [Test]
        public void IsOddChecker_InputOddNumber_ReturnTrue()
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOdd = calc.IsOddNumber(11);

            //Assert
            ClassicAssert.That(isOdd, Is.EqualTo(true));
            //OR:
            //ClassicAssert.IsTrue(isOdd);
        }
    }
}
