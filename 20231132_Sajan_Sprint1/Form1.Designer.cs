namespace _20231132_Sajan_Sprint1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pnlHeader = new Panel();
            lblBankName = new Label();
            lblTagline = new Label();

            grpCustomer = new GroupBox();
            lblCustNumTitle = new Label();
            lblCustNum = new Label();
            lblCustNameTitle = new Label();
            lblCustName = new Label();
            lblContactTitle = new Label();
            lblContact = new Label();
            rbRegular = new RadioButton();
            rbStaff = new RadioButton();

            grpAccount = new GroupBox();
            lblSelectAccount = new Label();
            cmbAccounts = new ComboBox();
            lblBalanceTitle = new Label();
            lblBalance = new Label();
            lblAccountDetails = new Label();

            grpTransaction = new GroupBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnInterest = new Button();
            lblStatusTitle = new Label();
            lblStatus = new Label();

            grpHistory = new GroupBox();
            lstHistory = new ListBox();

            pnlHeader.SuspendLayout();
            grpCustomer.SuspendLayout();
            grpAccount.SuspendLayout();
            grpTransaction.SuspendLayout();
            grpHistory.SuspendLayout();
            SuspendLayout();

            // =====================
            // Header Panel (compact)
            // =====================
            pnlHeader.BackColor = Color.FromArgb(27, 42, 74);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 50;
            pnlHeader.Controls.Add(lblBankName);
            pnlHeader.Controls.Add(lblTagline);

            lblBankName.AutoSize = true;
            lblBankName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBankName.ForeColor = Color.White;
            lblBankName.Location = new Point(12, 5);
            lblBankName.Text = "SwiftBank";

            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Segoe UI", 8F);
            lblTagline.ForeColor = Color.LightSteelBlue;
            lblTagline.Location = new Point(14, 32);
            lblTagline.Text = "Your Money, Simplified";

            // =====================
            // Customer Information
            // =====================
            grpCustomer.Location = new Point(12, 58);
            grpCustomer.Size = new Size(420, 100);
            grpCustomer.Text = "Customer Information";
            grpCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpCustomer.Controls.Add(lblCustNumTitle);
            grpCustomer.Controls.Add(lblCustNum);
            grpCustomer.Controls.Add(lblCustNameTitle);
            grpCustomer.Controls.Add(lblCustName);
            grpCustomer.Controls.Add(lblContactTitle);
            grpCustomer.Controls.Add(lblContact);
            grpCustomer.Controls.Add(rbRegular);
            grpCustomer.Controls.Add(rbStaff);

            lblCustNumTitle.AutoSize = true;
            lblCustNumTitle.Font = new Font("Segoe UI", 9F);
            lblCustNumTitle.Location = new Point(12, 22);
            lblCustNumTitle.Text = "Customer #:";

            lblCustNum.AutoSize = true;
            lblCustNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustNum.Location = new Point(105, 22);
            lblCustNum.Text = "C-1001";

            lblCustNameTitle.AutoSize = true;
            lblCustNameTitle.Font = new Font("Segoe UI", 9F);
            lblCustNameTitle.Location = new Point(200, 22);
            lblCustNameTitle.Text = "Name:";

            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustName.Location = new Point(250, 22);
            lblCustName.Text = "Sajan";

            lblContactTitle.AutoSize = true;
            lblContactTitle.Font = new Font("Segoe UI", 9F);
            lblContactTitle.Location = new Point(12, 44);
            lblContactTitle.Text = "Contact:";

            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContact.Location = new Point(105, 44);
            lblContact.Text = "sajan@email.com";

            rbRegular.AutoSize = true;
            rbRegular.Font = new Font("Segoe UI", 9F);
            rbRegular.Location = new Point(12, 70);
            rbRegular.Text = "Regular Customer";
            rbRegular.Checked = true;

            rbStaff.AutoSize = true;
            rbStaff.Font = new Font("Segoe UI", 9F);
            rbStaff.Location = new Point(190, 70);
            rbStaff.Text = "Bank Staff (50% fee discount)";
            rbStaff.CheckedChanged += rbStaff_CheckedChanged;

            // =====================
            // Account Selection
            // =====================
            grpAccount.Location = new Point(12, 163);
            grpAccount.Size = new Size(420, 160);
            grpAccount.Text = "Account";
            grpAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAccount.Controls.Add(lblSelectAccount);
            grpAccount.Controls.Add(cmbAccounts);
            grpAccount.Controls.Add(lblBalanceTitle);
            grpAccount.Controls.Add(lblBalance);
            grpAccount.Controls.Add(lblAccountDetails);

            lblSelectAccount.AutoSize = true;
            lblSelectAccount.Font = new Font("Segoe UI", 9F);
            lblSelectAccount.Location = new Point(12, 25);
            lblSelectAccount.Text = "Select Account:";

            cmbAccounts.Font = new Font("Segoe UI", 10F);
            cmbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccounts.Location = new Point(120, 22);
            cmbAccounts.Size = new Size(285, 25);
            cmbAccounts.SelectedIndexChanged += cmbAccounts_SelectedIndexChanged;

            lblBalanceTitle.AutoSize = true;
            lblBalanceTitle.Font = new Font("Segoe UI", 9F);
            lblBalanceTitle.Location = new Point(12, 58);
            lblBalanceTitle.Text = "Current Balance";

            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBalance.ForeColor = Color.FromArgb(0, 100, 0);
            lblBalance.Location = new Point(10, 78);
            lblBalance.Text = "$0.00";

            lblAccountDetails.Font = new Font("Segoe UI", 9F);
            lblAccountDetails.Location = new Point(12, 120);
            lblAccountDetails.Size = new Size(395, 35);
            lblAccountDetails.Text = "";

            // =====================
            // Transaction Controls
            // =====================
            grpTransaction.Location = new Point(445, 58);
            grpTransaction.Size = new Size(390, 265);
            grpTransaction.Text = "Perform Transaction";
            grpTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpTransaction.Controls.Add(lblAmount);
            grpTransaction.Controls.Add(txtAmount);
            grpTransaction.Controls.Add(btnDeposit);
            grpTransaction.Controls.Add(btnWithdraw);
            grpTransaction.Controls.Add(btnInterest);
            grpTransaction.Controls.Add(lblStatusTitle);
            grpTransaction.Controls.Add(lblStatus);

            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F);
            lblAmount.Location = new Point(12, 25);
            lblAmount.Text = "Enter Amount ($):";

            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(12, 45);
            txtAmount.Size = new Size(365, 27);

            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.BackColor = Color.FromArgb(46, 139, 87);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.Location = new Point(12, 82);
            btnDeposit.Size = new Size(175, 38);
            btnDeposit.Text = "Deposit";
            btnDeposit.Cursor = Cursors.Hand;
            btnDeposit.Click += btnDeposit_Click;

            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.BackColor = Color.FromArgb(205, 92, 92);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWithdraw.Location = new Point(200, 82);
            btnWithdraw.Size = new Size(177, 38);
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.Cursor = Cursors.Hand;
            btnWithdraw.Click += btnWithdraw_Click;

            btnInterest.FlatStyle = FlatStyle.Flat;
            btnInterest.BackColor = Color.FromArgb(70, 130, 180);
            btnInterest.ForeColor = Color.White;
            btnInterest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInterest.Location = new Point(12, 128);
            btnInterest.Size = new Size(365, 35);
            btnInterest.Text = "Calculate Interest";
            btnInterest.Cursor = Cursors.Hand;
            btnInterest.Click += btnInterest_Click;

            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusTitle.Location = new Point(12, 175);
            lblStatusTitle.Text = "Last Transaction:";

            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.Location = new Point(12, 195);
            lblStatus.Size = new Size(365, 60);
            lblStatus.Text = "No transactions yet";
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);

            // =====================
            // Transaction History
            // =====================
            grpHistory.Location = new Point(12, 330);
            grpHistory.Size = new Size(823, 155);
            grpHistory.Text = "Transaction History";
            grpHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpHistory.Controls.Add(lstHistory);

            lstHistory.Font = new Font("Consolas", 9F);
            lstHistory.Location = new Point(8, 20);
            lstHistory.Size = new Size(807, 125);
            lstHistory.BorderStyle = BorderStyle.FixedSingle;
            lstHistory.IntegralHeight = false;

            // =====================
            // Form Settings
            // =====================
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 495);
            Controls.Add(pnlHeader);
            Controls.Add(grpCustomer);
            Controls.Add(grpAccount);
            Controls.Add(grpTransaction);
            Controls.Add(grpHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SwiftBank - Account Manager";
            BackColor = Color.FromArgb(245, 245, 250);

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            grpTransaction.ResumeLayout(false);
            grpTransaction.PerformLayout();
            grpHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblBankName;
        private Label lblTagline;

        private GroupBox grpCustomer;
        private Label lblCustNumTitle;
        private Label lblCustNum;
        private Label lblCustNameTitle;
        private Label lblCustName;
        private Label lblContactTitle;
        private Label lblContact;
        private RadioButton rbRegular;
        private RadioButton rbStaff;

        private GroupBox grpAccount;
        private Label lblSelectAccount;
        private ComboBox cmbAccounts;
        private Label lblBalanceTitle;
        private Label lblBalance;
        private Label lblAccountDetails;

        private GroupBox grpTransaction;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnInterest;
        private Label lblStatusTitle;
        private Label lblStatus;

        private GroupBox grpHistory;
        private ListBox lstHistory;
    }
}
