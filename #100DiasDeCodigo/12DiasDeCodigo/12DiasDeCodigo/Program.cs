// Herança
using _12DiasDeCodigo.Entities;

BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

Console.WriteLine(account.Balance);

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// UPCASTING
// A subclasse BusinessAccount é uma Account.
// A superclasse pode receber um objeto de qualquer subclasse que a herde.
Account acc1 = bacc;
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

// DOWNCAST
// Para converter uma variável do tipo Account em uma variável da subclasse é preciso fazer um cast.
BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);

// A variável acc3 não pode ser convertida para outra subclasse por estar instanciada em SavingsAccount(subclasse).
// BusinessAccount acc5 = (BusinessAccount)acc3;
if (acc3 is BusinessAccount)
{
    // BusinessAccount acc5 = (BusinessAccount)acc3;
    // OU
    BusinessAccount? acc5 = acc3 as BusinessAccount;
    acc5!.Loan(200.0);
    Console.WriteLine("Loan!");
}

if (acc3 is SavingsAccount)
{
    // SavingsAccount acc5 = (SavingsAccount)acc3;
    //OU
    SavingsAccount? acc5 = acc3 as SavingsAccount;
    acc5!.UpdateBalance();
    Console.WriteLine("Update!");
}
