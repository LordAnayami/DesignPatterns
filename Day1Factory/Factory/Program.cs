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
            PlatiniumFactory platiniumFactory = new PlatiniumFactory();
            ICreditCards cardCard = platiniumFactory.CreateProduct(); 
            if (cardCard != null)
            {
                Console.WriteLine("CardType: " + cardCard.GetCardType());
                Console.WriteLine("CreditLimit: " + cardCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge: " + cardCard.GetAnnualCharge());
            }
            else
            { 
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}