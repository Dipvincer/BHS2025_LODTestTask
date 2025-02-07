using System.Threading;

public class BankAccount
{
    private decimal _balance;
    private readonly object _balanceLock = new object();

    public decimal Balance
    {
        get
        {
            lock (_balanceLock)
            {
                return _balance;
            }
        }
    }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Начальный баланс не может быть отрицательным.");
        }
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        lock (_balanceLock)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма для внесения должна быть положительной.");
            }

            _balance += amount;
            Console.WriteLine($"Внесено: {amount}. Текущий баланс: {_balance}");
        }
    }

    public void Withdraw(decimal amount)
    {
        lock (_balanceLock)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма для снятия должна быть положительной.");
            }
            if (_balance < amount)
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }
            
            _balance -= amount;
            Console.WriteLine($"Снято: {amount}. Текущий баланс: {_balance}");
        }
    }
}