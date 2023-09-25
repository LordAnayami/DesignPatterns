using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] arg)
        { 
            ICreditCards cardDetails = CreditCardFactory.GetCreditCard("Platinium");
            if (cardDetails != null)
            {
                Console.WriteLine("CardType: " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit: " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge: " + cardDetails.GetAnnualCharge());
            }
            else
            { 
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}