public class AccountService
{
    public decimal Deposit(decimal balance, decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive");
        return balance + amount;
    }
}