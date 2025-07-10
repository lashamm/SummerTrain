namespace SummerTrain 
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Deposit { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Balance { get; set; }

        
        public Bank() { }
        public Bank(
            int id, 
            string name, 
            decimal deposit, 
            decimal withdrawal, 
            decimal balance
            )
        {
            Id = id;
            Name = name;
            Deposit = deposit;
            Withdrawal = withdrawal;
            Balance = balance;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Deposit += amount;
            Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal.");
            }
            Withdrawal += amount;
            Balance -= amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Id: {Id}" +
                $"\nName: {Name}" +
                $"\nDeposit: {Deposit:C}" +
                $"\nWithdrawal: {Withdrawal:C}" +
                $"\nBalance: {Balance:C}");
        }
    }
} 
