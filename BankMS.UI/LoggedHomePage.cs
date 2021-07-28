using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankMS.UI
{
    public partial class LoggedHomePage : Form
    {
        public LoggedHomePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAccounts_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            pnlAccounts.BackColor = Color.Blue;
            btnAccounts.BackColor = Color.Blue;
        }

        private void LoggedHomePage_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccounts_MouseLeave(object sender, EventArgs e)
        {
            pnlAccounts.BackColor = Color.WhiteSmoke;
            btnAccounts.BackColor = Color.WhiteSmoke;
        }
    }
}
