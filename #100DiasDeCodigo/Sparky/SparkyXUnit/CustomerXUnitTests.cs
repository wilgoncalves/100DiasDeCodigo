using Xunit;

namespace Sparky
{
    public class CustomerXUnitTests
    {
        private Customer? _customer;

        public CustomerXUnitTests()
        {
            _customer = new Customer();
        }

        [Fact]
        public void CombineNames_InputFirstAndLastName_ReturnFullName()
        {
            _customer!.GreetAndCombineNames("Willian", "Gonçalves");
 
            Assert.Equal("Hello, Willian Gonçalves", _customer.GreetMessage);
            Assert.Contains("willian Gonçalves".ToLower(), _customer.GreetMessage!.ToLower()); // Case sensitive
            Assert.StartsWith("Hello,", _customer.GreetMessage);
            Assert.EndsWith("Gonçalves", _customer.GreetMessage);
            Assert.Matches("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", _customer.GreetMessage);
        }

        [Fact]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            // arrange

            // act

            // assert
            Assert.Null(_customer!.GreetMessage);
        }

        [Fact]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = _customer!.Discount;
            Assert.InRange(result, 10, 25);
        }

        [Fact]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            _customer!.GreetAndCombineNames("ben", "");

            Assert.NotNull(_customer.GreetMessage);
            Assert.False(string.IsNullOrEmpty(_customer.GreetMessage));
        }

        [Fact]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            var exceptionDetails = Assert.Throws<ArgumentException>(()
                => _customer!.GreetAndCombineNames("", "Spark"));

            Assert.Equal("Empty first name.", exceptionDetails!.Message);

            // Exceptions without message:
            Assert.Throws<ArgumentException>(() => _customer!.GreetAndCombineNames("", "Spark"));
        }

        // Assert Object Type:
        [Fact]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnsBasicCustomer()
        {
            _customer!.OrderTotal = 10;
            var result = _customer.GetCustomerDetails();
            Assert.IsType<BasicCustomer>(result);
        }

        [Fact]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnsPlatinumCustomer()
        {
            _customer!.OrderTotal = 200;
            var result = _customer.GetCustomerDetails();
            Assert.IsType<PlatinumCustomer>(result);
        }
    }
}
