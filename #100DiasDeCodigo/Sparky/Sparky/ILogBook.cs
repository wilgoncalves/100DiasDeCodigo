namespace Sparky
{
    public interface ILogBook
    {
        void Message(string message);

        bool LogToDb(string message);

        bool LogBalanceAfterWithdrawal(int balanceAfterWithdrawal);

        string MessageWithReturnString(string message);
    }
}
