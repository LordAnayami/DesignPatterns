using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PlatiniumFactory : CreditCardFactory
    {
        protected override ICreditCards MakeProduct()
        {
            ICreditCards product = new Platinium();
            return product;
        }
    }
}
