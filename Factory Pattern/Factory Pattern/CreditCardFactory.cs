using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class CreditCardFactory
    {
        public static  CreditCard GetCreditCard(string cardType)
        {
            switch (cardType)
            {
                case "Platinum":
                    return new Platinum(cardType);
                case "Titanium":
                    return new Titanium(cardType);
                case "MoneyBack":
                    return new MoneytBack(cardType);
                default:
                    return null;
            }
        }
    }
}
