﻿using BankMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace BankMS.UI
{
    public partial class RegPage : Form
    {
        UserModel user;
        public RegPage(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void RegPage_Load(object sender, EventArgs e)
        {
            SetUpBindingSourceForComponents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage(this);
            this.Close();
            log.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetValidators();
            regBindingSource.EndEdit();
            UserModel user = regBindingSource.Current as UserModel;
            ValidatingRegForm(user);
            MessageBox.Show("Sucessfull Registration", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LoginPage log = new LoginPage(this);
            this.Hide();
            log.Show();

        }
        private bool ValidatingRegForm(UserModel user)
        {
            ValidationContext context = new ValidationContext(user, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    string memberString = string.Concat(result.MemberNames);
                    ErrorLogging(result, memberString);
                }
                return false;
            }
            else
            {
                return true;
            }
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
            //cmbAccountType.DataBindings.Add("");
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

    }
}