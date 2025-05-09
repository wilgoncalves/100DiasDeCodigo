namespace Sparky
{
    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LogFaker : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
