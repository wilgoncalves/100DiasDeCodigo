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
            // Allows to test every single line:
            ClassicAssert.Multiple(() =>
            {
                ClassicAssert.AreEqual(_customer.GreetMessage, "Hello, Willian Gonçalves");
                // OR:
                ClassicAssert.That(_customer.GreetMessage, Is.EqualTo("Hello, Willian Gonçalves"));
                ClassicAssert.That(_customer.GreetMessage, Does.Contain("willian Gonçalves").IgnoreCase); // Case sensitive
                ClassicAssert.That(_customer.GreetMessage, Does.StartWith("Hello,"));
                ClassicAssert.That(_customer.GreetMessage, Does.EndWith("Gonçalves"));
                ClassicAssert.That(_customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            });
            
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

        [Test]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            _customer!.GreetAndCombineNames("ben", "");

            ClassicAssert.IsNotNull(_customer.GreetMessage);
            ClassicAssert.IsFalse(string.IsNullOrEmpty(_customer.GreetMessage));
        }

        [Test]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            var exceptionDetails = ClassicAssert.Throws<ArgumentException>(()
                => _customer!.GreetAndCombineNames("", "Spark"));

            ClassicAssert.AreEqual("Empty first name.", exceptionDetails!.Message);
            // OR:
            ClassicAssert.That(() => _customer!.GreetAndCombineNames("", "Spark"), 
                Throws.ArgumentException.With.Message.EqualTo("Empty first name."));

            // Exceptions without message:
            ClassicAssert.Throws<ArgumentException>(() => _customer!.GreetAndCombineNames("", "Spark"));

            ClassicAssert.That(() => _customer!.GreetAndCombineNames("", "Spark"), Throws.ArgumentException);

        }

        // Assert Object Type:
        [Test]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnsBasicCustomer()
        {
            _customer!.OrderTotal = 10;
            var result = _customer.GetCustomerDetails();
            ClassicAssert.That(result, Is.TypeOf<BasicCustomer>());
        }

        [Test]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnsPlatinumCustomer()
        {
            _customer!.OrderTotal = 200;
            var result = _customer.GetCustomerDetails();
            ClassicAssert.That(result, Is.TypeOf<PlatinumCustomer>());
        }
    }
}
