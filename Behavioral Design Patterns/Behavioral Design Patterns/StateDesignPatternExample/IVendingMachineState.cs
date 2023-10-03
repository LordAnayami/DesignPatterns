using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternExample
{
    // The State interface defines the common methods for all the concrete state classes.
    // The State Interface declares methods that all Concrete State Classes should implement 
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, string productName);
        void DispenseProduct();
    }
}
