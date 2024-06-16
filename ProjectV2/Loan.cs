using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV2
{
    abstract class Loan : ILoanConstraints
    {
        private string loanNumber;
        private string customerLastName, CustomerFirstName;
        private double loanAmount, interestRate;
        private int loanTerm;

        protected Loan(string loanNumber, string customerLastName, string customerFirstName, double loanAmount, int loanTerm)
        {
            LoanNumber = loanNumber;
            CustomerLastName = customerLastName;
            CustomerFirstName = customerFirstName;
            LoanAmount = Math.Min(loanAmount, ILoanConstraints.MaxLoanAmount);
            if (loanTerm == ILoanConstraints.shortTerm || loanTerm == ILoanConstraints.mediumTerm || loanTerm == ILoanConstraints.longTerm)
            {
                LoanTerm = loanTerm;
            }
            else { loanTerm = ILoanConstraints.shortTerm; }
        }

        public string LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerFirstName1 { get => CustomerFirstName; set => CustomerFirstName = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int LoanTerm { get => loanTerm; set => loanTerm = value; }

        public override string? ToString()
        {
            return $"Loan Number: {LoanNumber}\nCustomer: {CustomerFirstName} {CustomerLastName}\n" +
                    $"Loan Amount: R{LoanAmount}\nInterest Rate: {InterestRate}%\nTerm: {LoanTerm} years";
        }
        public abstract double CalculateInterestRate(double primeInterestRate);
    }
}
