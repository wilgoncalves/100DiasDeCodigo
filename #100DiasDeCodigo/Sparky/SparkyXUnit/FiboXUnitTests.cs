//using NUnit.Framework;
//using NUnit.Framework.Legacy;
//using Sparky;

//namespace Sparky
//{
//    [TestFixture]
//    public class FiboXUnitTests
//    {
//        private Fibo? _fibo;

//        [SetUp]
//        public void SetUp()
//        {
//            _fibo = new Fibo();
//        }

//        [Test]
//        public void FiboChecker_InputRange1_ReturnsFiboSeries()
//        {
//            List<int> expectedRange = new() { 0 };

//            _fibo!.Range = 1;

//            List<int> result = _fibo!.GetFiboSeries();

//            ClassicAssert.That(result, Is.Not.Empty);
//            ClassicAssert.That(result, Is.Ordered);
//            ClassicAssert.That(result, Is.EquivalentTo(expectedRange));
//        }

//        [Test]
//        public void FiboChecker_InputRange6_ReturnsFiboSeries()
//        {
//            List<int> expectedRange = new() { 0, 1, 1, 2, 3, 5 };

//            _fibo!.Range = 6;

//            List<int> result = _fibo!.GetFiboSeries();

//            ClassicAssert.That(result, Does.Contain(3));
//            ClassicAssert.That(result.Count, Is.EqualTo(6));
//            ClassicAssert.That(result, Has.No.Member(4));
//            ClassicAssert.That(result, Is.EquivalentTo(expectedRange));
//        }

//    }

//}
