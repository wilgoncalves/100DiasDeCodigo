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

        // My resolution
        [Test]
        public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse()
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.IsAny<int>())).Returns(false);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(200);

            var result = bankAccount.Withdraw(300);
            ClassicAssert.IsFalse(result);
        }
        // Or => teacher's resolution:
        [Test]
        [TestCase(200, 300)]
        public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse(int balance, int withdraw)
        {
            var logMock = new Mock<ILogBook>();
            
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x > 0))).Returns(true);
            //logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x < 0))).Returns(false); // OR:
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.IsInRange<int>(int.MinValue, -1, Moq.Range.Inclusive ))).Returns(false);


            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(balance);

            var result = bankAccount.Withdraw(withdraw);
            ClassicAssert.IsFalse(result);
        }

        [Test]
        public void BankLogDummy_LogMockString_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            string desiredOutput = "hello";

            logMock.Setup(u => u.MessageWithReturnString(It.IsAny<string>()))
                .Returns((string str) => str.ToLower());

            ClassicAssert.That(logMock.Object.MessageWithReturnString("HeLlo"), Is.EqualTo(desiredOutput));
        }
    }
}
