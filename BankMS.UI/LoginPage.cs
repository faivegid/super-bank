﻿using System;
using System.Windows.Forms;

namespace BankMS.UI
{

    public partial class LoginPage : Form
    {
        RegPage rg;
        private string email;
        private string password;

        public LoginPage(RegPage rg)
        {
           InitializeComponent();
            this.rg = rg; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
             rg.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblEmailValidity.Text = "";
            lblValidPassword.Text = "";
            lblEmailPassword.Text = "";
            email = txtEmail.Text;
            password = txtPassword.Text;

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
            }

            try
            {
                // checking database whether the email and password match in the database
                if (email == password)
                    throw new Exception("Email or password is wrong");
            }
            catch (Exception ex)
            {
                lblEmailPassword.Text = ex.Message;
            }
        }
    }
}