using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternExample
{
    // Concrete State B
    // Concrete States implement various behaviors, associated with a state of the Context.
    // The following Concrete State class implement behavior when the Vending Machine State is HasMoneyState
    public class HasMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine Dispensed the Product");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine("Already Vending machine has money and product selected, So wait till it finish the current dispensing process");
        }
    }
}
