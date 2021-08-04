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
using System.Globalization;
using BankMS.Model;

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
            userName = name;
            this.writer = writer;
            this.reader = reader;
            this.userId = userId;
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId).ToArray();
            transactions = reader.GetTransactions();
            acctNumbindingSource.DataSource = accounts;
            lblName.Text = userName;
            lblUserName.Text = userName;
            InitialisedDatatSource();
        }

        private void LoggedHomePage_Load(object sender, EventArgs e)
        {
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId).ToArray();
            transactions = reader.GetTransactions();
            lblName.Text = userName;
            lblUserName.Text = userName;
            cmbAccountNumber.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }

        public void ShowTransactions(List<string[]> transact)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Acoount Number", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            for (int i = 0; i < transact.Count; i++)
            {
                table.Rows.Add(transact[i][0], transact[i][1], transact[i][3], transact[i][2]);
            }
            transactionView.DataSource = table;
        }
        private List<string[]> GetAccountTransaction(string accountNumber)
        {
            return transactions.Where(t => t.AccountNumber == accountNumber).Select(x => new string[] { x.Date, x.AccountNumber, x.Amount, x.Note }).ToList();
        }

        private decimal GetAmountFromTransactions(string accountNumber)
        {
            var amounts = GetAccountTransaction(accountNumber).Select(x => decimal.Parse(x[2]));
            decimal balance = amounts.Sum();
            return balance;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            txtDepositAmount.Text = "";
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId);
            cmbDeposit.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (cmbDeposit.SelectedValue == null)
            {
                MessageBox.Show("Please select an account from the drop down", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            string accountNum = cmbDeposit.SelectedItem.ToString();
            decimal balance = GetAmountFromTransactions(accountNum);
            decimal minBalance = CheckMinBalance(accountNum);
            decimal amount = 0;
            bool success = decimal.TryParse(txtDepositAmount.Text, out amount);
            if (success && amount > 0)
            {
                writer.SaveTransactions(AccountRepository.Deposite(amount.ToString("0.00"), accountNum));
                MessageBox.Show("Sucessfull Deposit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            cmbWithdrawal.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }
        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (cmbWithdrawal.SelectedValue == null)
            {
                MessageBox.Show("Please select an account from the drop down", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            string accountNum = cmbWithdrawal.SelectedItem.ToString();
            decimal balance = GetAmountFromTransactions(accountNum);
            decimal minBalance = CheckMinBalance(accountNum);
            int amount = 0;
            bool success = int.TryParse(withAmount.Text, out amount);
            if (success && amount > 0)
            {
                if (minBalance > balance - amount)
                {
                    MessageBox.Show("Insufficient Funds", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    writer.SaveTransactions(AccountRepository.WithDraw(amount.ToString("0.00"), accountNum));
                    MessageBox.Show("Sucessfull Withdrawal", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Transfer_Click(object sender, EventArgs e)
        {       
            cmbTransfer.DataSource = accounts.Select(account => account.AccountNumber).ToList();
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int amount = 0;
            bool success = int.TryParse(trfamount.Text, out amount);
            string accountTransferTo = acctNum.Text;
            if (cmbTransfer.SelectedValue == null)
            {
                MessageBox.Show("Please select an account from the drop down", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            string accountTransferFrom = cmbTransfer.SelectedItem.ToString();
            TryTransfer(amount, success, accountTransferTo, accountTransferFrom);
        }
        private void TryTransfer(int amount, bool success, string accountTransferTo, string accountTransferFrom)
        {
            decimal balance = GetAmountFromTransactions(accountTransferFrom);
            decimal minBalance = CheckMinBalance(accountTransferFrom);
            if (IsAccountInDatabase(accountTransferTo))
            {
                if (accountTransferFrom == accountTransferTo)
                {
                    MessageBox.Show("Cant transfer to thesame account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (success && amount > 0)
                {
                    if (minBalance > balance - amount)
                    {
                        MessageBox.Show("Insufficient Funds", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var transact = AccountRepository.Tramsfer(amount.ToString("0.00"), accountTransferFrom, accountTransferTo);
                        foreach (var item in transact)
                            writer.SaveTransactions(item);
                        MessageBox.Show("Successfull Transfer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private bool IsAccountInDatabase(string accountNumber)
        {
            return reader.GetAccounts().Where(account => account.AccountNumber == accountNumber).Count() > 0;
        }
        private void cmbAccountNumber_SelectedValueChanged(object sender, EventArgs e)
        {
            string accountNumber = cmbAccountNumber.SelectedValue.ToString();
            lblAccountBalance.Text = "₦ " + GetAmountFromTransactions(accountNumber).ToString("N1", CultureInfo.InvariantCulture);
            lblAccountBalance.Visible = true;
        }
        private void InitialisedDatatSource()
        {
            var dataSource = accounts.Select(account => account.AccountNumber).ToList();
            acctNumbindingSource.DataSource = dataSource;
            cmbAccountNumber.DataSource = dataSource;
            cmbDeposit.DataSource = dataSource;
            cmbWithdrawal.DataSource = dataSource;
            cmbTransfer.DataSource = dataSource;
            cmbTransactions.DataSource = dataSource;
            cmbCreateNew.DataSource = new List<string> { "Savings", "Current" };
        }
        private decimal CheckMinBalance(string accountNum)
        {
            string type = string.Concat(accounts.Where(n => n.AccountNumber == accountNum).Select(x => x.accountType));
            switch (type)
            {
                case "Savings":
                    return 1000;
                case "Current":
                    return 0;
                default:
                    break;
            }
            return 0;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId).ToArray();
            transactions = reader.GetTransactions();
            cmbAccountNumber.DataSource = accounts.Select(account => account.AccountNumber).ToList();
            string accountNumber = cmbAccountNumber.SelectedValue.ToString();
            lblAccountBalance.Text = "₦ " + GetAmountFromTransactions(accountNumber).ToString("N1", CultureInfo.InvariantCulture);
            lblAccountBalance.Visible = true;
        }
        private void cmbTransactions_SelectedValueChanged(object sender, EventArgs e)
        {
            string accountNUmber = cmbTransactions.SelectedItem.ToString();
            ShowTransactions(GetAccountTransaction(accountNUmber));
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (cmbCreateNew.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid account type from the drop down Menu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            string accountType = cmbCreateNew.SelectedValue.ToString();
            Account account = AccountRepository.CreateAccount(userId, accountType);
            if (account != null)
            {
                writer.SaveAccount(account);
                MessageBox.Show("Account Created Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId);
            }
            else
            {
                MessageBox.Show("Account Creation UnSuccessfull due to network error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }    
    }
}
