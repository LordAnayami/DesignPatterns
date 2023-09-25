using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class TytaniumFactory : CreditCardFactory
    {
        protected override ICreditCards MakeProduct()
        {
            ICreditCards product = new Tytanium();
            return product;
        }
    }
}
