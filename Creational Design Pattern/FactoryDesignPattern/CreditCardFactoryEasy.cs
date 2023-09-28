using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class CreditCardFactoryEasy
    {
        public static ICreditCards GetCreditCard(string cardType)
        {
            ICreditCards cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Tytanium")
            {
                cardDetails = new Tytanium();
            }
            else if (cardType == "Platinium")
            {
                cardDetails = new Platinium();
            }
            return cardDetails;
        }
    }
}
