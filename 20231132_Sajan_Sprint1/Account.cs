namespace _20231132_Sajan_Sprint1
{
    /// <summary>
    /// Abstract base class for all bank account types.
    /// Cannot be instantiated directly.
    /// </summary>
    public abstract class Account
    {
        // Private fields - encapsulated data
        private string accountId;
        private string accountName;
        private decimal balance;
        private string lastTransactionStatus;
        private List<string> transactionHistory;

        // Protected field - accessible by child classes for fee calculations
        protected decimal feeDiscount;

        // Public read-only properties
        public string AccountId => accountId;
        public string AccountName => accountName;
        public decimal Balance => balance;
        public string LastTransactionStatus => lastTransactionStatus;
        public List<string> TransactionHistory => new List<string>(transactionHistory);

        // Protected accessors - allow child classes to modify balance and status
        protected decimal CurrentBalance
        {
            get => balance;
            set => balance = value;
        }

        /// <summary>
        /// Protected constructor - enforces that Account cannot be created directly.
        /// Child classes must chain to this using the base keyword.
        /// </summary>
        protected Account(string accountId, string accountName, decimal initialBalance, decimal feeDiscount)
        {
            this.accountId = accountId;
            this.accountName = accountName;
            this.balance = initialBalance;
            this.feeDiscount = feeDiscount;
            this.lastTransactionStatus = "No transactions yet";
            this.transactionHistory = new List<string>();
        }

        /// <summary>
        /// Deposits money into the account. Virtual so child classes can override if needed.
        /// </summary>
        public virtual bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                LogTransaction("Deposit Failed: Amount must be positive");
                return false;
            }

            balance += amount;
            LogTransaction($"Deposit Successful: ${amount:F2} deposited. Balance: ${balance:F2}");
            return true;
        }

        /// <summary>
        /// Withdraws money from the account. Abstract because each account type
        /// has different rules (fees, overdraft, etc.).
        /// </summary>
        public abstract bool Withdraw(decimal amount);

        /// <summary>
        /// Calculates and applies interest. Virtual - override in accounts that earn interest.
        /// Base implementation returns 0 (e.g., Everyday account has no interest).
        /// </summary>
        public virtual decimal CalculateInterest()
        {
            return 0m;
        }

        /// <summary>
        /// Returns a formatted summary of the account.
        /// </summary>
        public override string ToString()
        {
            return $"{accountName} ({accountId}) | Balance: ${balance:F2} | {lastTransactionStatus}";
        }

        /// <summary>
        /// Protected helper - updates the last transaction status and adds to history.
        /// </summary>
        protected void LogTransaction(string status)
        {
            lastTransactionStatus = status;
            transactionHistory.Add(status);
        }
    }
}

