// To accept deposits and withdrawals
// Will be tracking every transaction instead of simply updating the values

namespace Classes;

public class Transaction
{
    // Fields - data members of a class or struct that store values or data associated with instances of that class or struct
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}