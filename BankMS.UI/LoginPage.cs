using BankMS.DataAccess;
using BankMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankMS.UI
{

    public partial class LoginPage : Form
    {
        private string email;
        private string password;
        private IReader reader;
        private IWriter writer;
        IEnumerable<(string Id, string Email, string Password, string FirstName, string LastName)> Users;
        public LoginPage(IReader reader, IWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegPage(reader, writer).Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ResetVAlidators();
            email = txtEmail.Text;
            password = txtPassword.Text;

            Users = reader.GetUsers();
            if (ValidatinguserInput())
            {
                var userr = Users.Where(existingUser => existingUser.Email == email).Select(user => (ID: user.Id, Name: string.Concat(user.FirstName, user.LastName))).ToList();
                
                MessageBox.Show("Sucessfull Login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoggedHomePage loggedIn=new LoggedHomePage(userr[0].ID,userr[0].Name, writer, reader);
                loggedIn.Show();
            }
        }
        private bool IsEmailValid(string email, string password)
        {
            foreach (var item in Users)
            {
                if (item.Email == email && item.Password == password)
                    return true;
            }
            return false;
        }
        private void ResetVAlidators()
        {
            lblEmailValidity.Text = "";
            lblValidPassword.Text = "";
            lblEmailPassword.Text = "";
        }
        private bool ValidatinguserInput()
        {
            bool succeess = false;
            ResetVAlidators();
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new ArgumentException("Input an Email");
                if (!Validation.Validate.CheckEmail(email))
                    throw new ArgumentException("Invalid Email format");
            }
            catch (Exception ex)
            {
                lblEmailValidity.Text = ex.Message;
                lblEmailValidity.Visible = true;
            }

            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new ArgumentException("Input your password");
            }
            catch (Exception ex)
            {
                lblValidPassword.Text = ex.Message;
                lblValidPassword.Visible = true;
                return succeess;
            }

            try
            {
                // checking database whether the email and password match in the database
                if (!IsEmailValid(email, password))
                    throw new Exception("Email or password is wrong");
                else
                    succeess = true;
            }
            catch (Exception ex)
            {
                lblEmailPassword.Text = ex.Message;
                lblEmailPassword.Visible = true;
            }
            return succeess;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
