using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Sparky
{
    [TestFixture]
    public class ProductNUnitTests
    {
        private Product? _product;

        [SetUp]
        public void SetUp()
        {
            _product = new Product();
        }

        [Test]
        public void GetProductPrice_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            _product!.Price = 50;

            var result = _product.GetPrice(new Customer() { IsPlatinum = true });

            ClassicAssert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void GetProductPriceMOQAbuse_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(u =>  u.IsPlatinum).Returns(true);

            _product!.Price = 50;

            var result = _product!.GetPrice(customer.Object);

            ClassicAssert.That(result, Is.EqualTo(40));
        }
    }
}
