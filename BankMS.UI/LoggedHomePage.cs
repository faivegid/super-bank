using BankMS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankMS.UI
{
    public partial class LoggedHomePage : Form
    {
        IWriter writer;
        IReader reader;
        string userName;
        IEnumerable<(string AccountId, string AccountNumber, string accountType)> accounts;
        IEnumerable<(string AccountNumber, string Amount, string Note, string Date)> transactions;
        public LoggedHomePage(string userId, string name, IWriter writer, IReader reader)
        {
            InitializeComponent();
            this.userName = name;   
            this.writer = writer;
            this.reader = reader;
            accounts = reader.GetAccounts().Where(aaccount => aaccount.AccountId == userId);
            transactions = reader.GetTransactions();
        }

        private void LoggedHomePage_Load(object sender, EventArgs e)
        {
            lblName.Text = userName;
            lblUserName.Text = userName;
            acctNumbindingSource.DataSource = accounts;
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
    }
}
