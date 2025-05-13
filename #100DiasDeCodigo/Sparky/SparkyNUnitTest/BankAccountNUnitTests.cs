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

        //[Test]
        //public void BankDepositLogFaker_Add100_ReturnsTrue()
        //{
        //    BankAccount bankAccount = new BankAccount(new LogFaker());

        //    var result = bankAccount!.Deposit(100);

        //    ClassicAssert.IsTrue(result);
        //    ClassicAssert.That(bankAccount.GetBalance(), Is.EqualTo(100)); 
        //}

        [Test]
        public void BankDepositMoq_Add100_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(x => x.Message(""));

            BankAccount bankAccount = new(logMock.Object);

            var result = bankAccount.Deposit(100);

            ClassicAssert.IsTrue(result);
            ClassicAssert.That(bankAccount.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        [TestCase(200, 100)]
        [TestCase(200, 150)]
        public void BankWithdraw_Withdraw100With200Balance_ReturnsTrue(int balance, int withdraw)
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x > 0))).Returns(true);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(balance);

            var result = bankAccount.Withdraw(withdraw);
            ClassicAssert.IsTrue(result);
        }
    }
}
