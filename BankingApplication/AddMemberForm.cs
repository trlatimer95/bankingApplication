﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class AddMemberForm : BankingApp_BaseForms.memberBaseForm
    {
        public Form originatingForm = null;
        public User currentUser = null;

        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void MemberCancelButton_Click(object sender, EventArgs e)
        {
            
            originatingForm.Enabled = true;
            originatingForm.Show();
            this.Close();
        }

        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int parsedSSN = Convert.ToInt32(memberSSNTextBox.Text.Replace("-", string.Empty));
                int parsedZip = Convert.ToInt32(memberZipTextBox.Text.Replace("-", string.Empty));
                string parsedMailZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
                int parsedCell = Convert.ToInt32(memberCellTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty));
                int homePhone;
                string parsedHome = memberHomeTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
                if (string.IsNullOrWhiteSpace(parsedHome))
                {
                    homePhone = 0;
                }
                else
                {
                    homePhone = Convert.ToInt32(parsedHome);
                }

                DataHelper.CreateMember(memberFNameTextBox.Text, memberLNameTextBox.Text, parsedSSN, memberIDNumTextBox.Text, memberDOBPicker.Value.ToString("yyyy-MM-dd"),
                    memberStreetTextBox.Text, memberCityTextBox.Text, memberStateTextBox.Text, parsedZip, parsedCell, memberEmailTextBox.Text,
                    currentUser.GetUserID(), memberMNameTextBox.Text, memberExtraAddrTextBox.Text, homePhone, mailAddrStreetTextBox.Text, mailAddrExtraTextBox.Text,
                    mailAddrCityTextBox.Text, mailAddrStateTextBox.Text, parsedMailZip);
                Console.WriteLine($"Member, {memberFNameTextBox.Text} {memberLNameTextBox.Text}, has been created by user {currentUser.GetUserID()}");
                originatingForm.Enabled = true;
                originatingForm.Show();
                this.Close();

            }
            return;
        }
    }
}
