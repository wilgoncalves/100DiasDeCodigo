namespace SingleResponsability.SR_Principle;

class RegistraLog : ILogger
{
    public void Info(string info)
    {
        Console.WriteLine(info);
    }
}
