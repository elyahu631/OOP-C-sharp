using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class MoneytBack : CreditCard
    {
        private string name;

        public MoneytBack(string name)
        {
            this.name = name;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCardLimit()
        {
            return 10000;
        }

        public string GetCardType()
        {
            return "MoneytBack";
        }
    }
}
