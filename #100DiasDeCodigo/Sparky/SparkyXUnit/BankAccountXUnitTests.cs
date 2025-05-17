using Moq;
using Xunit;

namespace Sparky
{
    public class BankAccountXUnitTests
    {
        [Fact]
        public void BankDepositMoq_Add100_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(x => x.Message(""));

            BankAccount bankAccount = new(logMock.Object);

            var result = bankAccount.Deposit(100);

            Assert.True(result);
            Assert.Equal(100, bankAccount.GetBalance());
        }

        [Theory]
        [InlineData(200, 100)]
        [InlineData(200, 150)]
        public void BankWithdraw_Withdraw100With200Balance_ReturnsTrue(int balance, int withdraw)
        {
            var logMock = new Mock<ILogBook>();
            logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x > 0))).Returns(true);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(balance);

            var result = bankAccount.Withdraw(withdraw);
            Assert.True(result);
        }

        // My resolution
        //[Fact]
        //public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse()
        //{
        //    var logMock = new Mock<ILogBook>();
        //    logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
        //    logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.IsAny<int>())).Returns(false);

        //    BankAccount bankAccount = new(logMock.Object);
        //    bankAccount.Deposit(200);

        //    var result = bankAccount.Withdraw(300);
        //    Assert.False(result);
        //}
        // Or => teacher's resolution:
        [Theory]
        [InlineData(200, 300)]
        public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse(int balance, int withdraw)
        {
            var logMock = new Mock<ILogBook>();

            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x > 0))).Returns(true);
            //logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x => x < 0))).Returns(false); // OR:
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.IsInRange<int>(int.MinValue, -1, Moq.Range.Inclusive))).Returns(false);

            BankAccount bankAccount = new(logMock.Object);
            bankAccount.Deposit(balance);

            var result = bankAccount.Withdraw(withdraw);
            Assert.False(result);
        }

        [Fact]
        public void BankLogDummy_LogMockString_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            string desiredOutput = "hello";

            logMock.Setup(u => u.MessageWithReturnString(It.IsAny<string>()))
                .Returns((string str) => str.ToLower());

            Assert.Equal(desiredOutput, logMock.Object.MessageWithReturnString("HeLlo"));
        }

        [Fact]
        public void BankLogDummy_LogMockStringOutputStr_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            string desiredOutput = "hello";

            logMock.Setup(u => u.LogWithOutputResult(It.IsAny<string>(),
                out desiredOutput)).Returns(true);

            string result = "";
            Assert.True(logMock.Object.LogWithOutputResult("Ben", out result));

            Assert.Equal(desiredOutput, result);
        }

        [Fact]
        public void BankLogDummy_LogRefChecker_ReturnsTrue()
        {
            var logMock = new Mock<ILogBook>();
            Customer customer = new Customer();
            Customer customerNotUsed = new Customer();

            logMock.Setup(u => u.LogWithRefObj(ref customer)).Returns(true);

            Assert.True(logMock.Object.LogWithRefObj(ref customer));
            Assert.False(logMock.Object.LogWithRefObj(ref customerNotUsed));
        }

        [Fact]
        public void BankLogDummy_SetAndGetLogTypeAndSeverityMock_MockTest()
        {
            var logMock = new Mock<ILogBook>();

            logMock.Setup(u => u.LogSeverity).Returns(10); //Defines a fixed behavior for LogSeverity,
            //always returning 10, ignoring any value assigned afterwards.

            logMock.SetupAllProperties(); // method to asign values
            logMock.Setup(u => u.LogType).Returns("warning");

            logMock.Object.LogSeverity = 100;

            Assert.Equal(100, logMock.Object.LogSeverity);
            Assert.Equal("warning", logMock.Object.LogType);

            // Callbacks:
            string logTemp = "Hello, ";
            logMock.Setup(u => u.LogToDb(It.IsAny<string>()))
                .Returns(true).Callback((string str) => logTemp += str);

            logMock.Object.LogToDb("Ben");
            Assert.Equal("Hello, Ben", logTemp);

            // Callbacks:
            int counter = 5;
            logMock.Setup(u => u.LogToDb(It.IsAny<string>()))
                .Callback(() => counter++) // It can also be called before the return statement.
                .Returns(true)
                .Callback(() => counter++);

            logMock.Object.LogToDb("Ben");
            logMock.Object.LogToDb("Ben");
            Assert.Equal(9, counter);
        }

        [Fact]
        public void BankLogDummy_VerifyExample()
        {
            var logMock = new Mock<ILogBook>();
            BankAccount bankAccount = new BankAccount(logMock.Object);

            bankAccount.Deposit(100);
            Assert.Equal(100, bankAccount.GetBalance());

            // Verification:
            logMock.Verify(u => u.Message(It.IsAny<string>()), Times.Exactly(2));
            logMock.Verify(u => u.Message("Deposit invoked."), Times.AtLeastOnce);
            logMock.Verify(u => u.Message("Test."), Times.AtLeastOnce);
            logMock.VerifySet(u => u.LogSeverity = 101, Times.Once);
            logMock.VerifyGet(u => u.LogSeverity, Times.Once);
        }
    }
}
