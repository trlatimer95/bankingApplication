﻿namespace BankingApplication
{
    partial class AddUserForm
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.Text = "Add User";
            // 
            // addUserPasswordConfirmTextBox
            // 
            this.addUserPasswordConfirmTextBox.PasswordChar = '*';
            this.addUserPasswordConfirmTextBox.TabIndex = 2;
            // 
            // addUserPasswordTextBox
            // 
            this.addUserPasswordTextBox.PasswordChar = '*';
            this.addUserPasswordTextBox.TabIndex = 1;
            // 
            // addUserUsernameTextBox
            // 
            this.addUserUsernameTextBox.TabIndex = 0;
            // 
            // userCancelButton
            // 
            this.userCancelButton.TabIndex = 0;
            this.userCancelButton.Click += new System.EventHandler(this.UserCancelButton_Click);
            // 
            // userCreateButton
            // 
            this.userCreateButton.TabIndex = 1;
            this.userCreateButton.Click += new System.EventHandler(this.UserCreateButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 234);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUserForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}