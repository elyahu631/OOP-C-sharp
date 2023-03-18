using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal interface CreditCard
    {
        string GetCardType();
        int GetCardLimit();
        int GetAnnualCharge();
    }
}
