namespace _20231132_Sajan_Sprint1
{
    /// <summary>
    /// Omni Account: Earns interest on balances exceeding $1,000,
    /// allows a specified overdraft, and charges fixed fees for failed transactions.
    /// </summary>
    public class OmniAccount : Account
    {
        // Private fields specific to Omni accounts
        private decimal interestRate;
        private decimal overdraftLimit;
        private decimal failedTransactionFee;

        // Public read-only properties
        public decimal InterestRate => interestRate;
        public decimal OverdraftLimit => overdraftLimit;
        public decimal FailedTransactionFee => failedTransactionFee;

        /// <summary>
        /// Constructor chains to base Account constructor using the base keyword.
        /// </summary>
        public OmniAccount(string accountId, decimal initialBalance, decimal feeDiscount,
            decimal interestRate, decimal overdraftLimit, decimal failedTransactionFee)
            : base(accountId, "Omni", initialBalance, feeDiscount)
        {
            this.interestRate = interestRate;
            this.overdraftLimit = overdraftLimit;
            this.failedTransactionFee = failedTransactionFee;
        }

        /// <summary>
        /// Withdrawal with overdraft support. Charges a fixed fee (with staff discount)
        /// if withdrawal exceeds balance + overdraft limit.
        /// </summary>
        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                LogTransaction("Withdrawal Failed: Amount must be positive");
                return false;
            }

            if (amount > Balance + overdraftLimit)
            {
                // Charge failed transaction fee (staff get 50% discount)
                decimal fee = failedTransactionFee * (1 - feeDiscount);
                CurrentBalance -= fee;
                LogTransaction($"Withdrawal Failed: Exceeds overdraft limit. Fee: ${fee:F2}. Balance: ${CurrentBalance:F2}");
                return false;
            }

            CurrentBalance -= amount;
            LogTransaction($"Withdrawal Successful: ${amount:F2} withdrawn. Balance: ${CurrentBalance:F2}");
            return true;
        }

        /// <summary>
        /// Calculates and applies interest only on the portion of balance exceeding $1,000.
        /// No interest if balance is $1,000 or below.
        /// </summary>
        public override decimal CalculateInterest()
        {
            if (Balance <= 1000)
            {
                LogTransaction("No interest applied (balance must exceed $1,000)");
                return 0m;
            }

            decimal interestableAmount = Balance - 1000;
            decimal interest = interestableAmount * interestRate;
            CurrentBalance += interest;
            LogTransaction($"Interest Applied: ${interest:F2} on ${interestableAmount:F2} at {interestRate:P2}. Balance: ${CurrentBalance:F2}");
            return interest;
        }
    }
}

