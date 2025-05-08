using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        private Calculator? _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Calculator();
        }

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
            double result = _calc!.AddNumbersDouble(a, b);

            ClassicAssert.AreEqual(15.9, result, 1);
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Act
            bool isOdd = _calc!.IsOddNumber(10);

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
            //Act
            bool isOdd = _calc!.IsOddNumber(a);

            //Assert
            Assert.That(isOdd, Is.EqualTo(true));
            //OR:
            //ClassicAssert.IsTrue(isOdd);
        }

        //Combine Unit Test with Expected Result
        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            return _calc!.IsOddNumber(a);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            // arrange
            List<int> expectedOddRange = new() { 5, 7, 9 }; // Input values: 5 - 10

            // act
            List<int> result = _calc!.GetOddRange(5, 10);

            // assert
            ClassicAssert.That(result, Is.EquivalentTo(expectedOddRange));
            //OR:
            //ClassicAssert.AreEqual(expectedOddRange, result);
            //ClassicAssert.Contains(7, result);
            ClassicAssert.That(result, Does.Contain(7));
            ClassicAssert.That(result, Is.Not.Empty);
            ClassicAssert.That(result.Count, Is.EqualTo(3));
            ClassicAssert.That(result, Has.No.Member(6));
            ClassicAssert.That(result, Is.Ordered);
            ClassicAssert.That(result, Is.Unique);
        }
    }
}
