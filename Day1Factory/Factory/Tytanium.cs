using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Tytanium : ICreditCards
    {
        public string GetCardType()
        {
            return "Tytanium Edge";
        }

        public int GetAnnualCharge()
        {
            return 25000;
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    }
}
