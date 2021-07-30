
namespace BankMS.UI
{
    partial class RegPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegPage));
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.btnRegSignUP = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.regBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFirstNameValidator = new System.Windows.Forms.Label();
            this.lblLastNameValidator = new System.Windows.Forms.Label();
            this.lblEmailValidator = new System.Windows.Forms.Label();
            this.lblRegPasswordValidator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Helvetica", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(542, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, -60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 263);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.txtRegFirstName);
            this.panelUser.Location = new System.Drawing.Point(60, 270);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(479, 50);
            this.panelUser.TabIndex = 0;
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.AcceptsTab = true;
            this.txtRegFirstName.BackColor = System.Drawing.Color.White;
            this.txtRegFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtRegFirstName.Location = new System.Drawing.Point(13, 12);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.PlaceholderText = "First Name";
            this.txtRegFirstName.Size = new System.Drawing.Size(465, 25);
            this.txtRegFirstName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtRegPassword);
            this.panel3.Location = new System.Drawing.Point(60, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 50);
            this.panel3.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.AcceptsTab = true;
            this.txtRegPassword.BackColor = System.Drawing.Color.White;
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPassword.ForeColor = System.Drawing.Color.Black;
            this.txtRegPassword.Location = new System.Drawing.Point(13, 12);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PlaceholderText = "Password";
            this.txtRegPassword.Size = new System.Drawing.Size(465, 25);
            this.txtRegPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(200, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRegLastName);
            this.panel1.Location = new System.Drawing.Point(60, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 50);
            this.panel1.TabIndex = 0;
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.AcceptsTab = true;
            this.txtRegLastName.BackColor = System.Drawing.Color.White;
            this.txtRegLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegLastName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegLastName.ForeColor = System.Drawing.Color.Black;
            this.txtRegLastName.Location = new System.Drawing.Point(13, 12);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.PlaceholderText = "Last Name";
            this.txtRegLastName.Size = new System.Drawing.Size(465, 25);
            this.txtRegLastName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtRegEmail);
            this.panel2.Location = new System.Drawing.Point(60, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 50);
            this.panel2.TabIndex = 0;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.AcceptsTab = true;
            this.txtRegEmail.BackColor = System.Drawing.Color.White;
            this.txtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegEmail.ForeColor = System.Drawing.Color.Black;
            this.txtRegEmail.Location = new System.Drawing.Point(13, 12);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.PlaceholderText = "Email";
            this.txtRegEmail.Size = new System.Drawing.Size(465, 25);
            this.txtRegEmail.TabIndex = 3;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.cmbAccountType.Font = new System.Drawing.Font("Helvetica Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Savings Account",
            "Current Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(65, 612);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(263, 33);
            this.cmbAccountType.TabIndex = 5;
            this.cmbAccountType.Text = "Account Type";
            // 
            // btnRegSignUP
            // 
            this.btnRegSignUP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnRegSignUP.FlatAppearance.BorderSize = 2;
            this.btnRegSignUP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btnRegSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegSignUP.Location = new System.Drawing.Point(225, 676);
            this.btnRegSignUP.Name = "btnRegSignUP";
            this.btnRegSignUP.Size = new System.Drawing.Size(150, 50);
            this.btnRegSignUP.TabIndex = 6;
            this.btnRegSignUP.Text = "Sign Up";
            this.btnRegSignUP.UseVisualStyleBackColor = true;
            this.btnRegSignUP.Click += new System.EventHandler(this.btnRegSignUP_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.linkLabel1.Location = new System.Drawing.Point(60, 752);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(283, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Sign In  ";
            this.linkLabel1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFirstNameValidator
            // 
            this.lblFirstNameValidator.AutoSize = true;
            this.lblFirstNameValidator.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameValidator.Location = new System.Drawing.Point(65, 320);
            this.lblFirstNameValidator.Name = "lblFirstNameValidator";
            this.lblFirstNameValidator.Size = new System.Drawing.Size(84, 21);
            this.lblFirstNameValidator.TabIndex = 0;
            this.lblFirstNameValidator.Text = "firstname";
            this.lblFirstNameValidator.Visible = false;
            // 
            // lblLastNameValidator
            // 
            this.lblLastNameValidator.AutoSize = true;
            this.lblLastNameValidator.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameValidator.Location = new System.Drawing.Point(65, 403);
            this.lblLastNameValidator.Name = "lblLastNameValidator";
            this.lblLastNameValidator.Size = new System.Drawing.Size(83, 21);
            this.lblLastNameValidator.TabIndex = 0;
            this.lblLastNameValidator.Text = "lastname";
            this.lblLastNameValidator.Visible = false;
            // 
            // lblEmailValidator
            // 
            this.lblEmailValidator.AutoSize = true;
            this.lblEmailValidator.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailValidator.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidator.Location = new System.Drawing.Point(65, 483);
            this.lblEmailValidator.Name = "lblEmailValidator";
            this.lblEmailValidator.Size = new System.Drawing.Size(53, 21);
            this.lblEmailValidator.TabIndex = 0;
            this.lblEmailValidator.Text = "email";
            this.lblEmailValidator.Visible = false;
            // 
            // lblRegPasswordValidator
            // 
            this.lblRegPasswordValidator.AutoSize = true;
            this.lblRegPasswordValidator.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegPasswordValidator.ForeColor = System.Drawing.Color.Red;
            this.lblRegPasswordValidator.Location = new System.Drawing.Point(65, 563);
            this.lblRegPasswordValidator.Name = "lblRegPasswordValidator";
            this.lblRegPasswordValidator.Size = new System.Drawing.Size(87, 21);
            this.lblRegPasswordValidator.TabIndex = 0;
            this.lblRegPasswordValidator.Text = "password";
            this.lblRegPasswordValidator.Visible = false;
            // 
            // RegPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRegSignUP);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRegPasswordValidator);
            this.Controls.Add(this.lblEmailValidator);
            this.Controls.Add(this.lblLastNameValidator);
            this.Controls.Add(this.lblFirstNameValidator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRegLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Button btnRegSignUP;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.BindingSource regBindingSource;
        private System.Windows.Forms.Label lblFirstNameValidator;
        private System.Windows.Forms.Label lblLastNameValidator;
        private System.Windows.Forms.Label lblEmailValidator;
        private System.Windows.Forms.Label lblRegPasswordValidator;
    }
}