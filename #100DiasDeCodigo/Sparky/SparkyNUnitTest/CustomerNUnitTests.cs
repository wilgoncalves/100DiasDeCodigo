using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer? _customer;
        // Global inicialization for class
        [SetUp]
        public void SetUp()
        {
            _customer = new Customer();
        }

        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnFullName()
        {
            _customer!.GreetAndCombineNames("Willian", "Gonçalves");

            ClassicAssert.AreEqual(_customer.GreetMessage, "Hello, Willian Gonçalves");
            // OR:
            ClassicAssert.That(_customer.GreetMessage, Is.EqualTo("Hello, Willian Gonçalves"));
            ClassicAssert.That(_customer.GreetMessage, Does.Contain("willian Gonçalves").IgnoreCase); // Case sensitive
            ClassicAssert.That(_customer.GreetMessage, Does.StartWith("Hello,"));
            ClassicAssert.That(_customer.GreetMessage, Does.EndWith("Gonçalves"));
            ClassicAssert.That(_customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            // arrange

            // act
            
            // assert
            ClassicAssert.IsNull(_customer!.GreetMessage);
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = _customer!.Discount;
            ClassicAssert.That(result, Is.InRange(10, 25));
        }
    }
}
