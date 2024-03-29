﻿using System;

namespace BankingApplication
{
    public class Loan
    {
        // Instance Variables
        public int LoanID { get; set; }
        public int MemberID { get; set; }
        public string LoanType { get; set; }
        public string Description { get; set; }
        public double CurrentBalance { get; set; }
        public double APR { get; set; }
        public int TermLength { get; set; }
        public int DayDue { get; set; }
        public double StartingBalance { get; set; }
        public int JointMemberID { get; set; }
        public string JointMemberName { get; set; }
        public string JointMemberSSN { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public double NextPaymentDue { get; set; }
        public DateTime NextDueDate { get; set; }
        public double Payoff { get; set; }

        // Constructor with all variables - Joint info is optional
        public Loan(int ID, int memID, string loanType, string loanDescription, double loanBalance, double apr, int term, int dayDue, double startingBalance, DateTime openDate, DateTime closeDate, int jointID = 0, string jointName = null, string jointSSN = null)
        {
            LoanID = ID;
            MemberID = memID;
            LoanType = loanType;
            Description = loanDescription;
            CurrentBalance = loanBalance;
            APR = apr;
            TermLength = term;
            DayDue = dayDue;
            StartingBalance = startingBalance;
            JointMemberID = jointID;
            JointMemberName = jointName;
            JointMemberSSN = jointSSN;
            DateOpened = openDate;
            DateClosed = closeDate;
        }

        // Calculate loan payments
        public static double CalculatePayment(double amount, int payments, double interestRate)
        {
            // Convert APR from percentage to decimal value
            double apr = (interestRate * 0.01) / 12;
            // Calculate discount factor
            double discountFactor = (Math.Pow(1 + apr, payments) - 1) / (Math.Pow((1 + apr), payments) * apr);
            // Calculate payment
            double payment = amount / discountFactor;
            // Return payment amount
            return payment;
        }

        // Calculate total cost of the loan
        public static double CalculateTotalCost(double amount, int payments, double interestRate)
        {
            // Convert APR from percentage to decimal value
            double apr = (interestRate * 0.01) / 12;
            // Calculate discount factor
            double discountFactor = 1 - Math.Pow((1 + apr), (payments * -1));
            // Calculate total cost
            double totalCost = (apr * amount * payments) / discountFactor;
            // Return total loan cost
            return totalCost;
        }

        // Calculate current payoff amount
        public static double CalculatePayoffAmount(double amount, double interestRate)
        {
            // Convert APR from percentage to decimal
            double apr = (interestRate * 0.01) / 12;
            // Calculate payoff amount as of today
            double payoffAmount = amount * (1 + apr);
            // Return payoff amount
            return payoffAmount;
        }
    }
}
