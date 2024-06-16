using Loan_Application_System_PRG281;
using System;


namespace ProjectV2
{
    internal static class Program
    {
        /* 
        Johané Badenhorst 577401
        Janita de Vries	577698
        Zeldene van Vüren 577115
        Walter  Nienaber 577297
        Stefan  Sutherland 577574
        */

                [STAThread]
        static void Main()

        {
            Console.WriteLine();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Loan[] loans = new Loan[5];
            Console.Write("Enter the current prime interest rate: ");
            double primeInterestRate = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine($"Loan {i + 1} - Loan Type (B for Business, P for Personal):");
                char loanType = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter loan number: ");
                string loanNumber = (Console.ReadLine());

                Console.Write("Enter customer's last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter customer's first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter loan amount: ");
                double loanAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter loan term (1 for Short-Term, 3 for Medium-Term, 5 for Long-Term): ");
                int term = Convert.ToInt32(Console.ReadLine());


                if (loanType == 'B')
                {
                    loans[i] = new BusinessLoan(loanNumber, lastName, firstName, loanAmount, term,primeInterestRate);
                }
                else if (loanType == 'P')
                {
                    loans[i] = new PersonalLoan(loanNumber, lastName, firstName, loanAmount, term, primeInterestRate);
                }

                Console.WriteLine("\nLoan created:\n" + loans[i]);
            }


                Console.ReadLine();
        }
    }
}