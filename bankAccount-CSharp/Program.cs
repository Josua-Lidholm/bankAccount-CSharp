// Fulla pungen

// Skapa konto

using bankAccount_CSharp;

Console.WriteLine("Hej! Tryck för att skapa ett bankkonto!");

Console.ReadKey();

// Create account

Console.WriteLine("What's your name?");
var name = Console.ReadLine();

Account account = new Account(name);

while (true)
{
    Console.Clear();
    Console.WriteLine(account.AccountHolder);
    
    Console.WriteLine("Gör ditt val, fattiglapp!");
    Console.WriteLine("[1] Visa saldo");
    Console.WriteLine("[2] Sätta in pengar");
    Console.WriteLine("[3] Ta ut pengar");
    Console.WriteLine();
    Console.WriteLine();

    var input = Console.ReadKey();
    
    Console.Clear();
    
    switch (input.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine($"Ditt saldo är: {account.AccountBalance}");

            Console.WriteLine("Tryck på valfri knapp för att återgå till menyn...");
            Console.ReadKey();
            break; 
        
        case ConsoleKey.D2:
            Console.WriteLine("Välj summa att sätta in: ");
            var amountString = Console.ReadLine();

            decimal amountDec = 0;
            Decimal.TryParse(amountString, out amountDec);
    
            account.Deposit(amountDec);
            break;
        
        case ConsoleKey.D3:
            Console.WriteLine("Välj summa att ta ut: ");
            amountString = Console.ReadLine();

            amountDec = 0;
            Decimal.TryParse(amountString, out amountDec);
            
            account.Withdraw(amountDec);
            
            break;
        
        default:
            Console.WriteLine("Vänligen välj ett av alternativen.");
            Thread.Sleep(1000);
            break;
    }
    
    
}
