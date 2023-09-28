using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
     public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCards MakeProduct()
        {
            ICreditCards product = new MoneyBack();
            return product;
        }
    }
}
