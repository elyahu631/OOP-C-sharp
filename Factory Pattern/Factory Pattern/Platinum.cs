using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Platinum : CreditCard
    {
        private string name;

        public Platinum(string name)
        {
            this.name = name;
        }

        public int GetAnnualCharge()
        {
            return 100;
        }

        public int GetCardLimit()
        {
            return 5000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }
    }
}
