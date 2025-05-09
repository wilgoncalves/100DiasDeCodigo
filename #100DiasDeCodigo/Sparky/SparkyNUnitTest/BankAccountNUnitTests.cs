using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount? _bankAccount;

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void BankDepositLogFaker_Add100_ReturnsTrue()
        {
            BankAccount bankAccount = new BankAccount(new LogFaker());

            var result = _bankAccount!.Deposit(100);

            ClassicAssert.IsTrue(result);
            ClassicAssert.That(_bankAccount.GetBalance(), Is.EqualTo(100)); 
        }

        [Test]
        public void BankDepositMoq_Add100_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(x => x.Message(" "));

            BankAccount bankAccount = new(logMock.Object);

            var result = _bankAccount!.Deposit(100);

            ClassicAssert.IsTrue(result);
            ClassicAssert.That(_bankAccount.GetBalance(), Is.EqualTo(100));
        }
    }
}
