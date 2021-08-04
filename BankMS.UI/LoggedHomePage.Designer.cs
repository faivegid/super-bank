
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TabController = new System.Windows.Forms.TabControl();
            this.Accounts = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.cmbAccountNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDeposit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Withdrawal = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.withAmount = new System.Windows.Forms.TextBox();
            this.cmbWithdrawal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.trfamount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.acctNum = new System.Windows.Forms.TextBox();
            this.cmbTransfer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Transactions = new System.Windows.Forms.TabPage();
            this.transactionView = new System.Windows.Forms.DataGridView();
            this.cmbTransactions = new System.Windows.Forms.ComboBox();
            this.CreateNew = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.cmbCreateNew = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.acctNumbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TabController.SuspendLayout();
            this.Accounts.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Deposit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Withdrawal.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Transfer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionView)).BeginInit();
            this.CreateNew.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acctNumbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(700, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 40);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 186);
            this.panel1.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserName.Location = new System.Drawing.Point(238, 125);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(229, 48);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 165);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.Accounts);
            this.TabController.Controls.Add(this.Deposit);
            this.TabController.Controls.Add(this.Withdrawal);
            this.TabController.Controls.Add(this.Transfer);
            this.TabController.Controls.Add(this.Transactions);
            this.TabController.Controls.Add(this.CreateNew);
            this.TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabController.ItemSize = new System.Drawing.Size(100, 80);
            this.TabController.Location = new System.Drawing.Point(0, 186);
            this.TabController.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(739, 411);
            this.TabController.TabIndex = 0;
            // 
            // Accounts
            // 
            this.Accounts.BackColor = System.Drawing.Color.Gainsboro;
            this.Accounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accounts.Controls.Add(this.panel3);
            this.Accounts.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Accounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.Accounts.Location = new System.Drawing.Point(4, 84);
            this.Accounts.Name = "Accounts";
            this.Accounts.Padding = new System.Windows.Forms.Padding(3);
            this.Accounts.Size = new System.Drawing.Size(731, 323);
            this.Accounts.TabIndex = 0;
            this.Accounts.Text = "Accounts";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.cmbAccountNumber);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblAccountBalance);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(83, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 268);
            this.panel3.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnReload.FlatAppearance.BorderSize = 2;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReload.Location = new System.Drawing.Point(396, 215);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(127, 36);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.Font = new System.Drawing.Font("Helvetica Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAccountNumber.FormattingEnabled = true;
            this.cmbAccountNumber.Location = new System.Drawing.Point(225, 121);
            this.cmbAccountNumber.Name = "cmbAccountNumber";
            this.cmbAccountNumber.Size = new System.Drawing.Size(298, 33);
            this.cmbAccountNumber.TabIndex = 1;
            this.cmbAccountNumber.Text = "Select Account";
            this.cmbAccountNumber.SelectedValueChanged += new System.EventHandler(this.cmbAccountNumber_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Balance\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Name";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountBalance.Location = new System.Drawing.Point(226, 185);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(71, 24);
            this.lblAccountBalance.TabIndex = 0;
            this.lblAccountBalance.Text = "₦ 0.00";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(225, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "acct Name";
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.Gainsboro;
            this.Deposit.Controls.Add(this.panel4);
            this.Deposit.Location = new System.Drawing.Point(4, 84);
            this.Deposit.Name = "Deposit";
            this.Deposit.Padding = new System.Windows.Forms.Padding(3);
            this.Deposit.Size = new System.Drawing.Size(731, 323);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Deposit";
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txtDepositAmount);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cmbDeposit);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(83, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 268);
            this.panel4.TabIndex = 5;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDepositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtDepositAmount.Location = new System.Drawing.Point(204, 127);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(240, 31);
            this.txtDepositAmount.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(315, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(106, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount";
            // 
            // cmbDeposit
            // 
            this.cmbDeposit.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.cmbDeposit.FormattingEnabled = true;
            this.cmbDeposit.Location = new System.Drawing.Point(204, 63);
            this.cmbDeposit.Name = "cmbDeposit";
            this.cmbDeposit.Size = new System.Drawing.Size(240, 32);
            this.cmbDeposit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(43, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Account";
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.Color.Gainsboro;
            this.Withdrawal.Controls.Add(this.panel5);
            this.Withdrawal.Location = new System.Drawing.Point(4, 84);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(731, 323);
            this.Withdrawal.TabIndex = 2;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.withAmount);
            this.panel5.Controls.Add(this.cmbWithdrawal);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(85, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 268);
            this.panel5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(36, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(319, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // withAmount
            // 
            this.withAmount.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.withAmount.Location = new System.Drawing.Point(206, 122);
            this.withAmount.Name = "withAmount";
            this.withAmount.Size = new System.Drawing.Size(240, 31);
            this.withAmount.TabIndex = 5;
            // 
            // cmbWithdrawal
            // 
            this.cmbWithdrawal.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbWithdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.cmbWithdrawal.FormattingEnabled = true;
            this.cmbWithdrawal.Location = new System.Drawing.Point(206, 67);
            this.cmbWithdrawal.Name = "cmbWithdrawal";
            this.cmbWithdrawal.Size = new System.Drawing.Size(240, 32);
            this.cmbWithdrawal.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(99, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount";
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.Gainsboro;
            this.Transfer.Controls.Add(this.panel6);
            this.Transfer.Location = new System.Drawing.Point(4, 84);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(731, 323);
            this.Transfer.TabIndex = 3;
            this.Transfer.Text = "Transfer";
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.trfamount);
            this.panel6.Controls.Add(this.btnTransfer);
            this.panel6.Controls.Add(this.acctNum);
            this.panel6.Controls.Add(this.cmbTransfer);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(70, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(601, 280);
            this.panel6.TabIndex = 11;
            // 
            // trfamount
            // 
            this.trfamount.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trfamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.trfamount.Location = new System.Drawing.Point(309, 161);
            this.trfamount.Name = "trfamount";
            this.trfamount.Size = new System.Drawing.Size(240, 31);
            this.trfamount.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnTransfer.FlatAppearance.BorderSize = 2;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTransfer.Location = new System.Drawing.Point(422, 212);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(127, 42);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // acctNum
            // 
            this.acctNum.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acctNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.acctNum.Location = new System.Drawing.Point(309, 108);
            this.acctNum.Name = "acctNum";
            this.acctNum.Size = new System.Drawing.Size(240, 31);
            this.acctNum.TabIndex = 5;
            // 
            // cmbTransfer
            // 
            this.cmbTransfer.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.cmbTransfer.FormattingEnabled = true;
            this.cmbTransfer.Location = new System.Drawing.Point(309, 52);
            this.cmbTransfer.Name = "cmbTransfer";
            this.cmbTransfer.Size = new System.Drawing.Size(240, 32);
            this.cmbTransfer.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(213, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(16, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Select Account to transfer from";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(16, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Select Account to transfer from";
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.Gainsboro;
            this.Transactions.Controls.Add(this.transactionView);
            this.Transactions.Controls.Add(this.cmbTransactions);
            this.Transactions.Location = new System.Drawing.Point(4, 84);
            this.Transactions.Margin = new System.Windows.Forms.Padding(10, 3, 19, 3);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(731, 323);
            this.Transactions.TabIndex = 4;
            this.Transactions.Text = "Transactions";
            // 
            // transactionView
            // 
            this.transactionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionView.Location = new System.Drawing.Point(33, 64);
            this.transactionView.Name = "transactionView";
            this.transactionView.RowHeadersWidth = 62;
            this.transactionView.RowTemplate.Height = 33;
            this.transactionView.Size = new System.Drawing.Size(662, 251);
            this.transactionView.TabIndex = 9;
            // 
            // cmbTransactions
            // 
            this.cmbTransactions.FormattingEnabled = true;
            this.cmbTransactions.Location = new System.Drawing.Point(237, 17);
            this.cmbTransactions.Name = "cmbTransactions";
            this.cmbTransactions.Size = new System.Drawing.Size(240, 33);
            this.cmbTransactions.TabIndex = 8;
            this.cmbTransactions.Text = "Select Account";
            this.cmbTransactions.SelectedValueChanged += new System.EventHandler(this.cmbTransactions_SelectedValueChanged);
            // 
            // CreateNew
            // 
            this.CreateNew.BackColor = System.Drawing.Color.Gainsboro;
            this.CreateNew.Controls.Add(this.panel7);
            this.CreateNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.CreateNew.Location = new System.Drawing.Point(4, 84);
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(731, 323);
            this.CreateNew.TabIndex = 5;
            this.CreateNew.Text = "Create New";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.btnCreateAccount);
            this.panel7.Controls.Add(this.cmbCreateNew);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(87, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(557, 170);
            this.panel7.TabIndex = 11;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnCreateAccount.FlatAppearance.BorderSize = 2;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateAccount.Location = new System.Drawing.Point(352, 96);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(127, 51);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // cmbCreateNew
            // 
            this.cmbCreateNew.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.cmbCreateNew.Font = new System.Drawing.Font("Helvetica Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCreateNew.FormattingEnabled = true;
            this.cmbCreateNew.Location = new System.Drawing.Point(216, 43);
            this.cmbCreateNew.Name = "cmbCreateNew";
            this.cmbCreateNew.Size = new System.Drawing.Size(263, 33);
            this.cmbCreateNew.TabIndex = 6;
            this.cmbCreateNew.Text = "Account Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(51, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Account Type";
            // 
            // LoggedHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(739, 597);
            this.Controls.Add(this.TabController);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TabController.ResumeLayout(false);
            this.Accounts.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Deposit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Withdrawal.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Transfer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionView)).EndInit();
            this.CreateNew.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acctNumbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage Accounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Deposit;
        private System.Windows.Forms.TabPage Withdrawal;
        private System.Windows.Forms.TabPage Transfer;
        private System.Windows.Forms.TabPage Transactions;
        private System.Windows.Forms.ComboBox cmbAccountNumber;
        private System.Windows.Forms.BindingSource acctNumbindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbWithdrawal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox withAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox cmbTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox trfamount;
        private System.Windows.Forms.ComboBox cmbTransactions;
        private System.Windows.Forms.TextBox acctNum;
        private System.Windows.Forms.DataGridView transactionView;
        private System.Windows.Forms.TabPage CreateNew;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCreateNew;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}