using BankMS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankMS.Core;

namespace BankMS.UI
{
    public partial class LoggedHomePage : Form
    {
        IWriter writer;
        IReader reader;
        string userName;
        string userId;
        IEnumerable<(string AccountId, string AccountNumber, string accountType)> accounts;
        IEnumerable<(string AccountNumber, string Amount, string Note, string Date)> transactions;
        public LoggedHomePage(string userId, string name, IWriter writer, IReader reader)
        {
            InitializeComponent();
            this.userName = name;
            this.writer = writer;
            this.reader = reader;
            this.userId = userId;
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId);
            transactions = reader.GetTransactions();
            acctNumbindingSource.DataSource = accounts;
            lblName.Text = userName;
            lblUserName.Text = userName;
            initialisedDatatSource();
            CreateTabel();
        }

        private void initialisedDatatSource()
        {
            var dataSource = accounts.Select(account => account.AccountNumber).ToList();
            acctNumbindingSource.DataSource = dataSource;
            cmbAccountNumber.DataSource = dataSource;
            cmbSelectAccount.DataSource = dataSource;
            withComboAcct.DataSource = dataSource;
            trfcomboBox.DataSource = dataSource;
            transactcomboBox5.DataSource = dataSource;
        }

        private void LoggedHomePage_Load(object sender, EventArgs e)
        {
            lblName.Text = userName;
            lblUserName.Text = userName;
            cmbAccountNumber.DataSource = accounts.Select(account => account.AccountNumber).ToList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAccounts_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            pnlAccounts.BackColor = Color.Blue;
            btnAccounts.BackColor = Color.Blue;
        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccounts_MouseLeave(object sender, EventArgs e)
        {
            pnlAccounts.BackColor = Color.WhiteSmoke;
            btnAccounts.BackColor = Color.WhiteSmoke;
        }

        private void cmbAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBalance.Text = cmbAccountNumber.DisplayMember;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId);
            cmbSelectAccount.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            withComboAcct.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            trfcomboBox.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            transactcomboBox5.DataSource = accounts.Select(account => account.AccountNumber).ToList();
           
        }

        private void Accounts_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int amount = 0;
            bool success = int.TryParse(txtDepositAmount.Text, out amount);
            if (success && amount > 0)
            {
                AccountHandler.Deposite(amount.ToString("0.00"), cmbSelectAccount.SelectedItem.ToString(), writer);
                MessageBox.Show("Sucessfull Deposit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTrf_Click(object sender, EventArgs e)
        {
            int amount = 0;
            bool success = int.TryParse(trfamount.Text, out amount);

            string acctranfer = acctNum.Text;

            if (reader.GetAccounts().Where(account => account.AccountNumber == acctranfer).Count() > 0)
            {
                if (trfcomboBox.SelectedItem.ToString() == acctNum.Text)
                {
                    MessageBox.Show("Cant transfer to thesame account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (success && amount > 0)
                {
                    AccountHandler.Tramsfer(amount.ToString("0.00"), trfcomboBox.SelectedItem.ToString(), acctranfer, writer);
                    MessageBox.Show("Successfull Transfer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Account does not exist please check and try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amount = 0;
            bool success = int.TryParse(withAmount.Text, out amount);
            if (success && amount > 0)
            {
                AccountHandler.Deposite(amount.ToString("0.00"), withComboAcct.DisplayMember, writer);
                MessageBox.Show("Sucessfull Withdrawal", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transactionView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CreateTabel()
        {
            List<string[]> transact = transactions.Select(x => new string[] { x.Date, x.AccountNumber, x.Amount, x.Note }).ToList();

            //return transactions;
            DataTable table = new DataTable();

            table.Columns.Add("DATE", typeof(string));
            table.Columns.Add("ACCOUNT NUMBER", typeof(string));
            table.Columns.Add("TRANSACTION nOTE", typeof(string));
            table.Columns.Add("AMOUNT", typeof(decimal));
            for (int i = 0; i < transact.Count; i++)
            {
                table.Rows.Add(transact[i][0], transact[i][1], transact[i][3], transact[i][2]);
            }
            transactionView.DataSource = table;

        }
    }
}
