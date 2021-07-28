
namespace BankMS.UI
{
    partial class LoggedHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedHomePage));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.pnlAccounts = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlDeposite = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.pnlWtihdraw = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.TabController = new System.Windows.Forms.TabControl();
            this.Accounts = new System.Windows.Forms.TabPage();
            this.cmbAccountNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSelectAccount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.Withdrawal = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.withComboAcct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.withAmount = new System.Windows.Forms.TextBox();
            this.Transfer = new System.Windows.Forms.TabPage();
            this.btnTrf = new System.Windows.Forms.Button();
            this.trfcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trfamount = new System.Windows.Forms.TextBox();
            this.Transactions = new System.Windows.Forms.TabPage();
            this.transactcomboBox5 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.acctNumbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acctNum = new System.Windows.Forms.TextBox();
            this.transactionView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlDeposite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlWtihdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.TabController.SuspendLayout();
            this.Accounts.SuspendLayout();
            this.Deposit.SuspendLayout();
            this.Withdrawal.SuspendLayout();
            this.Transfer.SuspendLayout();
            this.Transactions.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acctNumbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(931, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 150);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 157);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserName.Location = new System.Drawing.Point(30, 184);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(229, 48);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccounts.Location = new System.Drawing.Point(3, 0);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(264, 55);
            this.btnAccounts.TabIndex = 4;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click_1);
            this.btnAccounts.MouseLeave += new System.EventHandler(this.btnAccounts_MouseLeave);
            this.btnAccounts.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // pnlAccounts
            // 
            this.pnlAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccounts.Controls.Add(this.pictureBox3);
            this.pnlAccounts.Controls.Add(this.btnAccounts);
            this.pnlAccounts.Location = new System.Drawing.Point(12, 248);
            this.pnlAccounts.Name = "pnlAccounts";
            this.pnlAccounts.Size = new System.Drawing.Size(268, 60);
            this.pnlAccounts.TabIndex = 5;
            this.pnlAccounts.Click += new System.EventHandler(this.btnAccounts_Click_1);
            this.pnlAccounts.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankMS.UI.Properties.Resources.view_details_48;
            this.pictureBox3.Location = new System.Drawing.Point(5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 51);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // pnlDeposite
            // 
            this.pnlDeposite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeposite.Controls.Add(this.pictureBox2);
            this.pnlDeposite.Controls.Add(this.btnDeposite);
            this.pnlDeposite.Location = new System.Drawing.Point(12, 314);
            this.pnlDeposite.Name = "pnlDeposite";
            this.pnlDeposite.Size = new System.Drawing.Size(268, 60);
            this.pnlDeposite.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankMS.UI.Properties.Resources.data_transfer_download_48;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 59);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeposite
            // 
            this.btnDeposite.FlatAppearance.BorderSize = 0;
            this.btnDeposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeposite.Location = new System.Drawing.Point(0, 1);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(267, 55);
            this.btnDeposite.TabIndex = 4;
            this.btnDeposite.Text = "Deposit";
            this.btnDeposite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // pnlWtihdraw
            // 
            this.pnlWtihdraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWtihdraw.Controls.Add(this.pictureBox4);
            this.pnlWtihdraw.Controls.Add(this.btnWithdraw);
            this.pnlWtihdraw.Location = new System.Drawing.Point(13, 381);
            this.pnlWtihdraw.Name = "pnlWtihdraw";
            this.pnlWtihdraw.Size = new System.Drawing.Size(267, 60);
            this.pnlWtihdraw.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 46);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.Location = new System.Drawing.Point(4, 1);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(262, 55);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransfer.Controls.Add(this.pictureBox5);
            this.pnlTransfer.Controls.Add(this.btnTransfer);
            this.pnlTransfer.Location = new System.Drawing.Point(12, 448);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(268, 60);
            this.pnlTransfer.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(7, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 59);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.Location = new System.Drawing.Point(5, 2);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(262, 55);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransaction.Controls.Add(this.pictureBox6);
            this.pnlTransaction.Controls.Add(this.btnTransactions);
            this.pnlTransaction.Location = new System.Drawing.Point(13, 514);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(267, 60);
            this.pnlTransaction.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(7, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 59);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // btnTransactions
            // 
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.Location = new System.Drawing.Point(-2, 2);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(258, 55);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.Accounts);
            this.TabController.Controls.Add(this.Deposit);
            this.TabController.Controls.Add(this.Withdrawal);
            this.TabController.Controls.Add(this.Transfer);
            this.TabController.Controls.Add(this.Transactions);
            this.TabController.ItemSize = new System.Drawing.Size(100, 80);
            this.TabController.Location = new System.Drawing.Point(0, 6);
            this.TabController.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(716, 474);
            this.TabController.TabIndex = 0;
            // 
            // Accounts
            // 
            this.Accounts.BackColor = System.Drawing.Color.Gainsboro;
            this.Accounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accounts.Controls.Add(this.cmbAccountNumber);
            this.Accounts.Controls.Add(this.label2);
            this.Accounts.Controls.Add(this.lblBalance);
            this.Accounts.Controls.Add(this.lblName);
            this.Accounts.Controls.Add(this.label3);
            this.Accounts.Controls.Add(this.label1);
            this.Accounts.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Accounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.Accounts.Location = new System.Drawing.Point(4, 84);
            this.Accounts.Name = "Accounts";
            this.Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.Accounts.Size = new System.Drawing.Size(708, 386);
            this.Accounts.TabIndex = 0;
            this.Accounts.Text = "Accounts";
            this.Accounts.Click += new System.EventHandler(this.Accounts_Click);
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.FormattingEnabled = true;
            this.cmbAccountNumber.Location = new System.Drawing.Point(238, 135);
            this.cmbAccountNumber.Name = "cmbAccountNumber";
            this.cmbAccountNumber.Size = new System.Drawing.Size(298, 41);
            this.cmbAccountNumber.TabIndex = 1;
            this.cmbAccountNumber.SelectedIndexChanged += new System.EventHandler(this.cmbAccountNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Balance\r\n";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(247, 222);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(178, 33);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "acct Balance";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(241, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "acct Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.Gainsboro;
            this.Deposit.Controls.Add(this.button1);
            this.Deposit.Controls.Add(this.cmbSelectAccount);
            this.Deposit.Controls.Add(this.label5);
            this.Deposit.Controls.Add(this.label4);
            this.Deposit.Controls.Add(this.txtDepositAmount);
            this.Deposit.Location = new System.Drawing.Point(4, 84);
            this.Deposit.Name = "Deposit";
            this.Deposit.Padding = new System.Windows.Forms.Padding(3);
            this.Deposit.Size = new System.Drawing.Size(708, 386);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Deposit";
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(319, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // cmbSelectAccount
            // 
            this.cmbSelectAccount.FormattingEnabled = true;
            this.cmbSelectAccount.Location = new System.Drawing.Point(206, 71);
            this.cmbSelectAccount.Name = "cmbSelectAccount";
            this.cmbSelectAccount.Size = new System.Drawing.Size(240, 33);
            this.cmbSelectAccount.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(206, 134);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(240, 31);
            this.txtDepositAmount.TabIndex = 0;
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.Color.Gainsboro;
            this.Withdrawal.Controls.Add(this.button2);
            this.Withdrawal.Controls.Add(this.withComboAcct);
            this.Withdrawal.Controls.Add(this.label6);
            this.Withdrawal.Controls.Add(this.label7);
            this.Withdrawal.Controls.Add(this.withAmount);
            this.Withdrawal.Location = new System.Drawing.Point(4, 84);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(708, 386);
            this.Withdrawal.TabIndex = 2;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(303, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 57);
            this.button2.TabIndex = 9;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // withComboAcct
            // 
            this.withComboAcct.FormattingEnabled = true;
            this.withComboAcct.Location = new System.Drawing.Point(190, 72);
            this.withComboAcct.Name = "withComboAcct";
            this.withComboAcct.Size = new System.Drawing.Size(240, 33);
            this.withComboAcct.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount";
            // 
            // withAmount
            // 
            this.withAmount.Location = new System.Drawing.Point(190, 135);
            this.withAmount.Name = "withAmount";
            this.withAmount.Size = new System.Drawing.Size(240, 31);
            this.withAmount.TabIndex = 5;
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.Gainsboro;
            this.Transfer.Controls.Add(this.btnTrf);
            this.Transfer.Controls.Add(this.trfcomboBox);
            this.Transfer.Controls.Add(this.label10);
            this.Transfer.Controls.Add(this.label8);
            this.Transfer.Controls.Add(this.label9);
            this.Transfer.Controls.Add(this.acctNum);
            this.Transfer.Controls.Add(this.trfamount);
            this.Transfer.Location = new System.Drawing.Point(4, 84);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(708, 386);
            this.Transfer.TabIndex = 3;
            this.Transfer.Text = "Transfer";
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // btnTrf
            // 
            this.btnTrf.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTrf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnTrf.FlatAppearance.BorderSize = 2;
            this.btnTrf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnTrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrf.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTrf.Location = new System.Drawing.Point(397, 253);
            this.btnTrf.Name = "btnTrf";
            this.btnTrf.Size = new System.Drawing.Size(127, 57);
            this.btnTrf.TabIndex = 9;
            this.btnTrf.Text = "Transfer";
            this.btnTrf.UseVisualStyleBackColor = false;
            this.btnTrf.Click += new System.EventHandler(this.btnTrf_Click);
            // 
            // trfcomboBox
            // 
            this.trfcomboBox.FormattingEnabled = true;
            this.trfcomboBox.Location = new System.Drawing.Point(284, 54);
            this.trfcomboBox.Name = "trfcomboBox";
            this.trfcomboBox.Size = new System.Drawing.Size(240, 33);
            this.trfcomboBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Select Account to transfer from";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Select Account to transfer from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount";
            // 
            // trfamount
            // 
            this.trfamount.Location = new System.Drawing.Point(284, 186);
            this.trfamount.Name = "trfamount";
            this.trfamount.Size = new System.Drawing.Size(240, 31);
            this.trfamount.TabIndex = 5;
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.Gainsboro;
            this.Transactions.Controls.Add(this.transactionView);
            this.Transactions.Controls.Add(this.transactcomboBox5);
            this.Transactions.Controls.Add(this.label11);
            this.Transactions.Location = new System.Drawing.Point(4, 84);
            this.Transactions.Margin = new System.Windows.Forms.Padding(10, 3, 19, 3);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(708, 386);
            this.Transactions.TabIndex = 4;
            this.Transactions.Text = "Transactions";
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // transactcomboBox5
            // 
            this.transactcomboBox5.FormattingEnabled = true;
            this.transactcomboBox5.Location = new System.Drawing.Point(158, 45);
            this.transactcomboBox5.Name = "transactcomboBox5";
            this.transactcomboBox5.Size = new System.Drawing.Size(240, 33);
            this.transactcomboBox5.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Select Account";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TabController);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(286, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(716, 483);
            this.panel7.TabIndex = 6;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // acctNum
            // 
            this.acctNum.Location = new System.Drawing.Point(284, 126);
            this.acctNum.Name = "acctNum";
            this.acctNum.Size = new System.Drawing.Size(240, 31);
            this.acctNum.TabIndex = 5;
            // 
            // transactionView
            // 
            this.transactionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionView.Location = new System.Drawing.Point(17, 108);
            this.transactionView.Name = "transactionView";
            this.transactionView.RowHeadersWidth = 62;
            this.transactionView.RowTemplate.Height = 33;
            this.transactionView.Size = new System.Drawing.Size(668, 266);
            this.transactionView.TabIndex = 9;
            this.transactionView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionView_CellContentClick);
            // 
            // LoggedHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1002, 640);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.pnlTransfer);
            this.Controls.Add(this.pnlWtihdraw);
            this.Controls.Add(this.pnlDeposite);
            this.Controls.Add(this.pnlAccounts);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoggedHomePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoggedHomePage_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlDeposite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlWtihdraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlTransfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.TabController.ResumeLayout(false);
            this.Accounts.ResumeLayout(false);
            this.Accounts.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.Deposit.PerformLayout();
            this.Withdrawal.ResumeLayout(false);
            this.Withdrawal.PerformLayout();
            this.Transfer.ResumeLayout(false);
            this.Transfer.PerformLayout();
            this.Transactions.ResumeLayout(false);
            this.Transactions.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acctNumbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Panel pnlAccounts;
        private System.Windows.Forms.Panel pnlDeposite;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.Panel pnlWtihdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Deposit;
        private System.Windows.Forms.TabPage Withdrawal;
        private System.Windows.Forms.TabPage Transfer;
        private System.Windows.Forms.TabPage Transactions;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmbAccountNumber;
        private System.Windows.Forms.BindingSource acctNumbindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSelectAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox withComboAcct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox withAmount;
        private System.Windows.Forms.Button btnTrf;
        private System.Windows.Forms.ComboBox trfcomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox trfamount;
        private System.Windows.Forms.ComboBox transactcomboBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox acctNum;
        private System.Windows.Forms.DataGridView transactionView;
    }
}