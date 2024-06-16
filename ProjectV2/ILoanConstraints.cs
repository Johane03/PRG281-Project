using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV2
{
    internal interface ILoanConstraints
    {
        const int shortTerm = 1;
        const int mediumTerm = 3;
        const int longTerm = 5;
        const string CompanyName = "Unique Building Services Loan Company";
        const int MaxLoanAmount = 100000;
    }
}
