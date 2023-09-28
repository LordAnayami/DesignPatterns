using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCards MakeProduct();

        public ICreditCards CreateProduct()
        {
            ICreditCards creditCard = this.MakeProduct();
            return creditCard;
        }
    }
    
    
}
