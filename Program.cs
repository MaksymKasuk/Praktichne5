class Program
{
    static void Main(string[] args)
    {
        CurrentAccount currentAccount = new CurrentAccount();
        currentAccount.Новий_рахунок();
        currentAccount.Поповнити_рахунок(1000);
        currentAccount.Зняти_з_рахунку(500);
        currentAccount.Видалити_рахунок();

        DepositAccount depositAccount = new DepositAccount();
        depositAccount.Новий_рахунок();
        depositAccount.Поповнити_рахунок(2000);
        depositAccount.Зняти_з_рахунку(1500);
        depositAccount.Видалити_рахунок();
    }
}
