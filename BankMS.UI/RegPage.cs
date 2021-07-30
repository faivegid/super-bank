using BankMS.Core;
using BankMS.DataAccess;
using BankMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace BankMS.UI
{
    public partial class RegPage : Form
    {
        private IReader reader;
        private IWriter writer;
        IEnumerable<(string Id, string Email, string Password, string FirstName, string LastName)> Users;
        UserModel user;
        public RegPage(IReader reader, IWriter writer)
        {
            InitializeComponent();
            this.reader = reader;
            this.writer = writer;
            this.user = new UserModel();
            Users = reader.GetUsers();
        }

        private void RegPage_Load(object sender, EventArgs e)
        {
            SetUpBindingSourceForComponents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage(reader, writer);
            this.Close();
            log.Show();
        }
        private void btnRegSignUP_Click(object sender, EventArgs e)
        {
            ResetValidators();
            regBindingSource.EndEdit();
            UserModel user = regBindingSource.Current as UserModel;

            if (!DoesErrorExistInRegForm(user))
            {
                writer.SaveUser(user);
                writer.SaveAccount(AccountHandler.CreateAccount(
                    user.Id, cmbAccountType.SelectedItem.ToString()));
                MessageBox.Show("Sucessfull Registration", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginPage log = new LoginPage(reader, writer);
                this.Hide();
                log.Show();
            }
        }
        private bool DoesErrorExistInRegForm(UserModel user)
        {
            if (DoesEmailExist(user))
            {
                MessageBox.Show("Email already Exist Please Login or Register using different Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            ValidationContext context = new ValidationContext(user, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    string memberString = string.Concat(result.MemberNames);
                    ErrorLogging(result, memberString);
                }
                return true;
            }
            else { return false; }
        }
        private void ErrorLogging(ValidationResult result, string memberString)
        {
            switch (memberString)
            {
                case "FirstName":
                    lblFirstNameValidator.Text = result.ErrorMessage;
                    lblFirstNameValidator.Visible = true;
                    break;
                case "LastName":
                    lblLastNameValidator.Text = result.ErrorMessage;
                    lblLastNameValidator.Visible = true;
                    break;
                case "Email":
                    lblEmailValidator.Text = result.ErrorMessage;
                    lblEmailValidator.Visible = true;
                    break;
                case "Password":
                    lblRegPasswordValidator.Text = result.ErrorMessage;
                    lblRegPasswordValidator.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void SetUpBindingSourceForComponents()
        {
            regBindingSource.DataSource = user;
            txtRegFirstName.DataBindings.Add("Text", regBindingSource, "FirstName",
                false, DataSourceUpdateMode.OnPropertyChanged);
            txtRegLastName.DataBindings.Add("Text", regBindingSource, "LastName",
                false, DataSourceUpdateMode.OnPropertyChanged);
            txtRegEmail.DataBindings.Add("Text", regBindingSource, "Email",
                false, DataSourceUpdateMode.OnPropertyChanged);
            txtRegPassword.DataBindings.Add("Text", regBindingSource, "Password",
                false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ResetValidators()
        {
            lblFirstNameValidator.Visible = false;
            lblLastNameValidator.Visible = false;
            lblEmailValidator.Visible = false;
            lblRegPasswordValidator.Visible = false;

            lblFirstNameValidator.Text = "";
            lblLastNameValidator.Text = "";
            lblEmailValidator.Text = "";
            lblRegPasswordValidator.Text = "";
        }
        private bool DoesEmailExist(UserModel user)
        {
            return Users.Where(existingUser => existingUser.Email == user.Email).Count() > 0;
        }

    }
}
