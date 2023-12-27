using Bank.Data;


BankAccount BankAccount = new BankAccount("Ivanna Zetino", 11.99);
BankAccount.Credit(5.77);
BankAccount.Debit(11.22);

Console.WriteLine($"Current balance is {BankAccount.GetBalance}");