using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Titanium : CreditCard
    {
        private string name;

        public Titanium(string name)
        {
            this.name = name;
        }

        public int GetAnnualCharge()
        {
            return 300;
        }

        public int GetCardLimit()
        {
            return 12000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }
    }
}
