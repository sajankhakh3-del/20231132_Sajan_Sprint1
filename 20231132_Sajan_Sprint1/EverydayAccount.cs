namespace _20231132_Sajan_Sprint1
{
    /// <summary>
    /// Everyday Account: No interest, no overdraft, no transaction fees.
    /// The simplest account type.
    /// </summary>
    public class EverydayAccount : Account
    {
        /// <summary>
        /// Constructor chains to base Account constructor.
        /// </summary>
        public EverydayAccount(string accountId, decimal initialBalance, decimal feeDiscount)
            : base(accountId, "Everyday", initialBalance, feeDiscount)
        {
        }

        /// <summary>
        /// Simple withdrawal - no fees, no overdraft allowed.
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
                LogTransaction($"Withdrawal Failed: Insufficient Funds (Tried: ${amount:F2}, Available: ${Balance:F2})");
                return false;
            }

            CurrentBalance -= amount;
            LogTransaction($"Withdrawal Successful: ${amount:F2} withdrawn. Balance: ${CurrentBalance:F2}");
            return true;
        }

        // No interest - uses base CalculateInterest() which returns 0
    }
}

