namespace Lab4_ex1
{
    public class Account
    {
        protected double balance;

        public Account(double initialize)
        {
            balance = initialize;
        }

        public virtual void Deposit(double money)
        {
            if (money > 0)
            {
                balance += money;
                Console.WriteLine("Gửi tiền thành công. Số dư hiện tại: {0}", balance);
            }
            else
            {
                Console.WriteLine("Số tiền gửi phải lớn hơn 0.");
            }
        }

        public virtual void Withdraw(double money)
        {
            if (money > 0 && money <= balance)
            {
                balance -= money;
                Console.WriteLine("Rút tiền thành công. Số dư hiện tại: {0}", balance);
            }
            else
            {
                Console.WriteLine("Số tiền rút không hợp lệ.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    public class SavingAccount : Account
    {
        private double rate;

        public SavingAccount(double initialize, double rate) : base(initialize)
        {
            this.rate = rate;
        }

        public double GetInterest()
        {
            return balance * rate;
        }
    }

    public class CheckAccount : Account
    {
        private double feeTransfer;

        public CheckAccount(double balance, double feeTransfer) : base(balance)
        {
            this.feeTransfer = feeTransfer;
        }

        public override void Deposit(double money)
        {
            base.Deposit(money);
            balance -= feeTransfer;
            Console.WriteLine("Đã trừ phí giao dịch. Số dư hiện tại: {0}", balance);
        }

        public override void Withdraw(double money)
        {
            base.Withdraw(money);
            balance -= feeTransfer;
            Console.WriteLine("Đã trừ phí giao dịch. Số dư hiện tại: {0}", balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo tài khoản tiết kiệm
            SavingAccount savingAccount = new SavingAccount(1000, 0.05);
            savingAccount.Deposit(500);
            Console.WriteLine("Lãi suất: {0}", savingAccount.GetInterest());

            // Tạo tài khoản thanh toán
            CheckAccount checkAccount = new CheckAccount(2000, 10);
            checkAccount.Withdraw(500);
        }
    }
}
