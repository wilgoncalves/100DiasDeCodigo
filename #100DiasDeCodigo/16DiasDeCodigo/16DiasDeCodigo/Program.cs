// Classes abstratas
using System.Globalization;
using _16DiasDeCodigo.Entities;

// Mesmo que a classe seja abstrata, ainda podemos chamá-la em uma lista.
List<Account> list = new List<Account>();

// A superclasse abstrata nos permite adicionar diferentes subclasses numa lista.
list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0.0;
foreach (var account in list)
{
    sum += account.Balance;
}

Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

// Chamadas polimórficas
foreach (var account in list)
{
    account.Withdraw(10.0);
}

// 
foreach (var account in list)
{
    Console.WriteLine($"Updated balance for account " +
        $"{account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}