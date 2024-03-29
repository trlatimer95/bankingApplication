﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Member
    {
        // Instance Variables
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string IDNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Street { get; set; }
        public string ExtraAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string MailStreet { get; set; }
        public string MailExtraAddress { get; set; }
        public string MailCity { get; set; }
        public string MailState { get; set; }
        public string MailZipCode { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }


        // Constructor with all variables - Mailing address and home phone are optional
        public Member(int ID, string fName, string lName, string ssn, string idNum, string dob, string Street, string City,
            string State, int ZipCode, string cell, string Email, string mName = null, string extraAddress = null, string home = null,
            string MailStreet = null, string MailExtraAddress = null, string MailCity = null, string MailState = null, string MailZipCode = null)
        {
            MemberID = ID; FirstName = fName; MiddleName = mName; LastName = lName; SocialSecurityNumber = ssn; IDNumber = idNum;
            Birthdate = Convert.ToDateTime(dob); this.Street = Street; this.City = City; this.State = State; this.ZipCode = ZipCode; this.MailStreet = MailStreet;
            this.MailExtraAddress = MailExtraAddress; this.MailCity = MailCity; this.MailState = MailState; this.MailZipCode = MailZipCode; CellPhone = cell;
            HomePhone = home; this.Email = Email;
        }
    }
}
