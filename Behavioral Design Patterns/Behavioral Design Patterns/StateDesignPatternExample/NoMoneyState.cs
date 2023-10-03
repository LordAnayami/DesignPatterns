using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternExample
{
    // Concrete State A
    // Concrete States implement various behaviors, associated with a state of the Context.
    // The following Concrete State class implement behavior when the Vending Machine State is NoMoneyState
    public class NoMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + "Rs has been inserted and " + productName + " has been selected");
        }
    }
}
