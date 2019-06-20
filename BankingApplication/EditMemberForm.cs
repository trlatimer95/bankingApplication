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
    public partial class EditMemberForm : BankingApp_BaseForms.memberBaseForm
    {
        public MainForm mainForm = null;
        public Member currentMember = null;

        public EditMemberForm()
        {
            InitializeComponent();
        }

        private void populateData()
        {
            memberFNameTextBox.Text = currentMember.FirstName;
            memberMNameTextBox.Text = currentMember.MiddleName;
            memberLNameTextBox.Text = currentMember.LastName;
            memberSSNTextBox.Text = currentMember.SocialSecurityNumber.ToString();
            memberIDNumTextBox.Text = currentMember.IDNumber;
            memberDOBPicker.Value = currentMember.Birthdate;
            memberStreetTextBox.Text = currentMember.Street;
            memberExtraAddrTextBox.Text = currentMember.ExtraAddress;
            memberCityTextBox.Text = currentMember.City;
            memberStateTextBox.Text = currentMember.State;
            memberZipTextBox.Text = currentMember.ZipCode.ToString();
            mailAddrStreetTextBox.Text = currentMember.MailStreet;
            if (string.IsNullOrWhiteSpace(mailAddrStreetTextBox.Text))
            {
                mailingSameCheckBox.Checked = true;
            }
            mailAddrExtraTextBox.Text = currentMember.MailExtraAddress;
            mailAddrCityTextBox.Text = currentMember.MailCity;
            mailAddrStateTextBox.Text = currentMember.MailState;
            mailAddrZipTextBox.Text = currentMember.MailZipCode;
            memberCellTextBox.Text = currentMember.CellPhone.ToString("#(###)###-####");
            memberHomeTextBox.Text = currentMember.HomePhone.ToString("#(###)###-####");
            memberEmailTextBox.Text = currentMember.Email;
        }

        private void MemberCancelButton_Click(object sender, EventArgs e)
        {
            
            mainForm.Enabled = true;
            mainForm.Show();
            this.Close();
        }

        private void MemberSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int parsedSSN = Convert.ToInt32(memberSSNTextBox.Text.Replace("-", string.Empty));
                int parsedZip = Convert.ToInt32(memberZipTextBox.Text.Replace("-", string.Empty));
                string parsedMailZip = mailAddrZipTextBox.Text.Replace("-", string.Empty);
                int homePhone;
                int parsedCell = Convert.ToInt32(memberCellTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty));
                string parsedHome = memberHomeTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
                if (string.IsNullOrWhiteSpace(parsedHome))
                {
                    homePhone = 0;
                } else
                {
                    homePhone = Convert.ToInt32(parsedHome);
                }
                 
                DataHelper.UpdateMember(currentMember.MemberID, memberFNameTextBox.Text, memberLNameTextBox.Text, parsedSSN, memberIDNumTextBox.Text, memberDOBPicker.Value.ToString("yyyy-MM-dd"),
                    memberStreetTextBox.Text, memberCityTextBox.Text, memberStateTextBox.Text, parsedZip, parsedCell, memberEmailTextBox.Text,
                    mainForm.currentUser.GetUserID(), memberMNameTextBox.Text, memberExtraAddrTextBox.Text, homePhone, mailAddrStreetTextBox.Text, mailAddrExtraTextBox.Text,
                    mailAddrCityTextBox.Text, mailAddrStateTextBox.Text, parsedMailZip);
                Console.WriteLine($"Member, {memberFNameTextBox.Text} {memberLNameTextBox.Text}, has been update by user {mainForm.currentUser.GetUserID()}");
                mainForm.Enabled = true;
                mainForm.Show();
                mainForm.PopulateData();
                this.Close();

            }
            return;
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            populateData();
        }
    }
}