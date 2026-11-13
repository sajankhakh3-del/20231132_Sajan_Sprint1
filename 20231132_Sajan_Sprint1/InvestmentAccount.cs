namespace _20231132_Sajan_Sprint1
{
    /// <summary>
    /// Investment Account: Earns variable interest, no overdraft allowed,
    /// and charges a fixed fee for failed transactions.
    /// </summary>
    public class InvestmentAccount : Account
    {
        // Private fields specific to Investment accounts
        private decimal interestRate;
        private decimal failedTransactionFee;

        // Public read-only properties
        public decimal InterestRate => interestRate;
        public decimal FailedTransactionFee => failedTransactionFee;

        /// <summary>
        /// Constructor chains to base Account constructor using the base keyword.
        /// </summary>
        public InvestmentAccount(string accountId, decimal initialBalance, decimal feeDiscount,
            decimal interestRate, decimal failedTransactionFee)
            : base(accountId, "Investment", initialBalance, feeDiscount)
        {
            this.interestRate = interestRate;
            this.failedTransactionFee = failedTransactionFee;
        }

        /// <summary>
        /// Withdrawal with no overdraft. Charges a fixed fee (with staff discount) on failed attempts.
        /// </summary>
        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                LogTransaction("Withdrawal Failed: Amount must be positive");
                return false;
            }

            if (amount > Balance)
            {
                // Charge failed transaction fee (staff get 50% discount)
                decimal fee = failedTransactionFee * (1 - feeDiscount);
                CurrentBalance -= fee;
                LogTransaction($"Withdrawal Failed: Insufficient Funds. Fee: ${fee:F2}. Balance: ${CurrentBalance:F2}");
                return false;
            }

            CurrentBalance -= amount;
            LogTransaction($"Withdrawal Successful: ${amount:F2} withdrawn. Balance: ${CurrentBalance:F2}");
            return true;
        }

        /// <summary>
        /// Calculates and applies interest on the full balance.
        /// </summary>
        public override decimal CalculateInterest()
        {
            decimal interest = Balance * interestRate;
            CurrentBalance += interest;
            LogTransaction($"Interest Applied: ${interest:F2} at {interestRate:P2}. Balance: ${CurrentBalance:F2}");
            return interest;
        }
    }
}

