public class BankAccount : IBankAccount
{
    public virtual void Новий_рахунок()
    {
        Console.WriteLine("Створено новий банківський рахунок.");
    }

    public virtual void Видалити_рахунок()
    {
        Console.WriteLine("Банківський рахунок видалено.");
    }
}
