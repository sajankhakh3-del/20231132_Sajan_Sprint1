namespace _20231132_Sajan_Sprint1
{
    public partial class Form1 : Form
    {
        // The customer object - all data and logic lives here, not in the form
        private Customer customer;

        public Form1()
        {
            InitializeComponent();
            LoadCustomer(false); // Start as regular customer
        }

        /// <summary>
        /// Creates a new customer and refreshes the entire form.
        /// Called on startup and when switching between Regular/Staff roles.
        /// </summary>
        private void LoadCustomer(bool isStaff)
        {
            customer = new Customer("C-1001", "Sajan", "sajan@email.com", isStaff);

            // Display customer info
            lblCustNum.Text = customer.CustomerNumber;
            lblCustName.Text = customer.Name;
            lblContact.Text = customer.ContactDetails;

            // Populate account dropdown
            cmbAccounts.Items.Clear();
            foreach (var account in customer.Accounts)
            {
                cmbAccounts.Items.Add(account.AccountName);
            }
            cmbAccounts.SelectedIndex = 0;
        }

        /// <summary>
        /// Returns whichever account is currently selected in the dropdown.
        /// </summary>
        private Account GetSelectedAccount()
        {
            if (cmbAccounts.SelectedIndex < 0) return customer.Accounts[0];
            return customer.Accounts[cmbAccounts.SelectedIndex];
        }

        /// <summary>
        /// Refreshes the balance, account details, status, and transaction history.
        /// This is the only place that reads data FROM the classes and shows it on screen.
        /// </summary>
        private void RefreshDisplay()
        {
            var account = GetSelectedAccount();

            // Update balance display
            lblBalance.Text = $"${account.Balance:F2}";

            // Change balance colour: green if positive, red if negative
            lblBalance.ForeColor = account.Balance >= 0
                ? Color.FromArgb(0, 100, 0)
                : Color.FromArgb(200, 0, 0);

            // Show account-specific details
            if (account is EverydayAccount)
            {
                lblAccountDetails.Text = "No interest  |  No overdraft  |  No fees";
            }
            else if (account is InvestmentAccount inv)
            {
                lblAccountDetails.Text = $"Interest: {inv.InterestRate:P2}  |  No overdraft  |  Failed Fee: ${inv.FailedTransactionFee:F2}";
            }
            else if (account is OmniAccount omni)
            {
                lblAccountDetails.Text = $"Interest: {omni.InterestRate:P2}  |  Overdraft: ${omni.OverdraftLimit:F2}  |  Failed Fee: ${omni.FailedTransactionFee:F2}";
            }

            // Update last transaction status
            lblStatus.Text = account.LastTransactionStatus;

            // Update transaction history list
            lstHistory.Items.Clear();
            foreach (var entry in account.TransactionHistory)
            {
                lstHistory.Items.Add(entry);
            }

            // Auto-scroll to latest transaction
            if (lstHistory.Items.Count > 0)
            {
                lstHistory.TopIndex = lstHistory.Items.Count - 1;
            }
        }

        // ========================
        // Event Handlers
        // ========================

        /// <summary>
        /// When a different account is selected, refresh the display.
        /// </summary>
        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        /// <summary>
        /// Deposit button - reads amount from textbox, calls Deposit on the account class.
        /// </summary>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the account's Deposit method - logic is in the class, not here
            GetSelectedAccount().Deposit(amount);
            RefreshDisplay();
            txtAmount.Clear();
        }

        /// <summary>
        /// Withdraw button - reads amount from textbox, calls Withdraw on the account class.
        /// </summary>
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the account's Withdraw method - fees and overdraft handled in the class
            GetSelectedAccount().Withdraw(amount);
            RefreshDisplay();
            txtAmount.Clear();
        }

        /// <summary>
        /// Interest button - calls CalculateInterest on the account class.
        /// </summary>
        private void btnInterest_Click(object sender, EventArgs e)
        {
            var account = GetSelectedAccount();

            // Everyday accounts have no interest
            if (account is EverydayAccount)
            {
                lblStatus.Text = "Everyday accounts do not earn interest.";
                return;
            }

            // Interest calculation happens inside the class
            account.CalculateInterest();
            RefreshDisplay();
        }

        /// <summary>
        /// Role switch - recreates the customer with the new role.
        /// Staff get 50% discount on transaction fees.
        /// </summary>
        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            LoadCustomer(rbStaff.Checked);
        }
    }
}
