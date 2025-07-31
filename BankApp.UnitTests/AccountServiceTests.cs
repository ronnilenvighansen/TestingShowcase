public class AccountServiceTests
{
    [Fact]
    public void Deposit_AddsAmountToBalance()
    {
        // Positive test: Valid input (50) added to balance (100)
        // Equivalence class: Valid deposit amounts (> 0)
        var service = new AccountService();
        var result = service.Deposit(100, 50);
        Assert.Equal(150, result);
    }

    [Theory]
    [InlineData(0)] // Boundary value: zero (just invalid)
    [InlineData(-10)] // Equivalence class: negative amounts
    public void Deposit_ThrowsException_WhenAmountIsNonPositive(decimal amount)
    {
        // Negative tests: invalid inputs should throw
        var service = new AccountService();
        Assert.Throws<ArgumentException>(() => service.Deposit(100, amount));
    }
}