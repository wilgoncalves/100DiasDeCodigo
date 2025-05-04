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
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.96
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            Calculator calc = new();

            double result = calc.AddNumbersDouble(a, b);

            ClassicAssert.AreEqual(15.9, result, 1);
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
        //Testing multiple values
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool isOdd = calc.IsOddNumber(a);

            //Assert
            ClassicAssert.That(isOdd, Is.EqualTo(true));
            //OR:
            //ClassicAssert.IsTrue(isOdd);
        }

        //Combine Unit Test with Expected Result
        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();

            return calc.IsOddNumber(a);
        }
    }
}
