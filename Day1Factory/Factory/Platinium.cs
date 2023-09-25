using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
     class Platinium : ICreditCards
    {
        public string GetCardType()
        {
            return "Tytanium Plus";
        }

        public int GetAnnualCharge()
        {
            return 35000;
        }

        public int GetCreditLimit()
        {
            return 2000;
        }
    }
}
