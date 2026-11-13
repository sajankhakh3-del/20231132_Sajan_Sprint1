namespace _20231132_Sajan_Sprint1
{
    /// <summary>
    /// Represents a bank customer. Holds customer details and a collection of accounts.
    /// Distinguishes between Regular Customers and Bank Staff.
    /// </summary>
    public class Customer
    {
        // Private fields
        private string customerNumber;
        private string name;
        private string contactDetails;
        private bool isStaff;
        private List<Account> accounts;

        // Public read-only properties
        public string CustomerNumber => customerNumber;
        public string Name => name;
        public string ContactDetails => contactDetails;
        public bool IsStaff => isStaff;
        public List<Account> Accounts => accounts;

        /// <summary>
        /// Creates a new customer and pre-populates with one of each account type.
        /// Staff members receive a 50% discount on transaction fees.
        /// </summary>
        public Customer(string customerNumber, string name, string contactDetails, bool isStaff)
        {
            this.customerNumber = customerNumber;
            this.name = name;
            this.contactDetails = contactDetails;
            this.isStaff = isStaff;
            this.accounts = new List<Account>();

            // Staff get 50% fee discount, regular customers get 0%
            decimal feeDiscount = isStaff ? 0.5m : 0m;

            // Pre-populate with one of each account type
            accounts.Add(new EverydayAccount("EVD-001", 1000.00m, feeDiscount));
            accounts.Add(new InvestmentAccount("INV-001", 5000.00m, feeDiscount, 0.05m, 10.00m));
            accounts.Add(new OmniAccount("OMN-001", 2000.00m, feeDiscount, 0.04m, 500.00m, 15.00m));
        }

        /// <summary>
        /// Returns formatted customer summary.
        /// </summary>
        public override string ToString()
        {
            return $"{name} ({customerNumber}) | Role: {(isStaff ? "Staff" : "Customer")} | Accounts: {accounts.Count}";
        }
    }
}

