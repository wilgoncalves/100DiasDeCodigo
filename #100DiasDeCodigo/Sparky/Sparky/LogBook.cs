namespace Sparky
{
    public class LogBook : ILogBook
    {
        public bool LogBalanceAfterWithdrawal(int balanceAfterWithdrawal)
        {
            if (balanceAfterWithdrawal >= 0)
            {
                Console.WriteLine("Success!");
                return true;
            }

            Console.WriteLine("Failure!");
            return false;
            
        }

        public bool LogToDb(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public string MessageWithReturnString(string message)
        {
            Console.WriteLine(message);
            return message.ToLower();
        }
    }

    //public class LogFaker : ILogBook
    //{
    //    public void Message(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}
}
