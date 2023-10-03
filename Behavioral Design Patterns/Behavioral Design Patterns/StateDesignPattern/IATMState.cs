using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    // The State Interface declares methods that all Concrete State Classes should implement 
    public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
