namespace bankAccount_CSharp;

public class Account
{
    // Fields and properties
    private string _accountHolder;
    public string AccountHolder
    {
        get { return _accountHolder;  }
        set { _accountHolder = value; }
    }
    
    private decimal _accountBalance;
    public decimal AccountBalance
    {
        get { return _accountBalance; }
        set { _accountBalance = value; }
    }

    // Constructor
    public Account(string name)
    {
        AccountHolder = name;
        AccountBalance = 0;
    }

    // Methods 
    public decimal ViewBalance()
    {
        return AccountBalance;
    }

    public void Deposit(decimal amount)
    {
            AccountBalance += amount;    
    }

    public void Withdraw(decimal amount)
    {
        AccountBalance -= amount;
    }
}