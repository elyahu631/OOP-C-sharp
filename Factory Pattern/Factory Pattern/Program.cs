using System;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard[] cardArray = {CreditCardFactory.GetCreditCard("Titanium"),
                                      CreditCardFactory.GetCreditCard("Platinum"),
                                      CreditCardFactory.GetCreditCard("Platinum"),
                                      CreditCardFactory.GetCreditCard("MoneyBack"),
                                      CreditCardFactory.GetCreditCard("MoneyBack")};

            foreach (CreditCard card in cardArray)
            {
                Console.WriteLine($"Card Type: {card.GetCardType()} | " +
                                  $"Card Limit: {card.GetCardLimit()} | " +                                  
                                  $"Card Charge: {card.GetAnnualCharge()}.");
            }
        }
    }
}
