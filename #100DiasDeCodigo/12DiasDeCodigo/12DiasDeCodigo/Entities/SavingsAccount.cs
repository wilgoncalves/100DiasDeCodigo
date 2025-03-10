namespace _12DiasDeCodigo.Entities
{
    // A palavra-chave "sealed" evita que a classe seja herdada.
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount (int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Sobreescrevendo um método já existente na superclasse.
        // Com a palavra-chave "sealed", informamos que o método não poderá ser sobescrito novamente em uma subclasse.
        public sealed override void Withdraw(double amount)
        {
            // Com a palavra "base", podemos chamar a implementação da superclasse e depois, fazer uma nova implementação.
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
