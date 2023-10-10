namespace Classes;

public class BankAccount
{
    public string Number { get; set; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name; // obj is constructed using this qualifier - it is optional
        this.Balance = initialBalance;
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

    }
}