namespace Classes;

public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890; // private data member 
    public string Number { get; set; }
    public string Owner { get; set; }

    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }     
    }
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name; // obj is constructed using this qualifier - it is optional
        this.Balance = initialBalance;
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        // Throw error if amount of deposit isn't greater than 0
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of desposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransaction.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

    }
}