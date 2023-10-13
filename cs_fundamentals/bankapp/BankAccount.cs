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

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

    }
}