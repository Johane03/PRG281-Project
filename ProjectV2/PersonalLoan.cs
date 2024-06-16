using ProjectV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System_PRG281
{
    internal class PersonalLoan : Loan
    {
        private double interestRate;
        public PersonalLoan( string loanNumber, string customerLastName, string customerFirstName, double loanAmount, int loanTerm,double interestRate) : base(loanNumber, customerLastName, customerFirstName, loanAmount, loanTerm)
        {
            this.interestRate = interestRate;
        }

        public double InterestRate1 { get => interestRate; set => interestRate = value; }

        public override double CalculateInterestRate(double primeInterestRate)
        {
            return  primeInterestRate + 0.02;
        }

    }
}
