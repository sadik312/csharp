using Classes;

var account = new BankAccount("John Smith", 1000);
Console.WriteLine($"Account {account.Number} was created fo {account.Owner} with {account.Balance} initial balance.");