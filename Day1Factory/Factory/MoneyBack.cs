using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
     class MoneyBack : ICreditCards
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetAnnualCharge()
        {
            return 15000;  
        }

        public int GetCreditLimit()
        {
            return 500;
        }
    }
}
