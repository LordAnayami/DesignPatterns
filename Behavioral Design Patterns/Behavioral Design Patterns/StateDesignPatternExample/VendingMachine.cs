using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternExample
{
    // The Context Class defines the interface which is going to be used by the clients. 
    // It also maintains a reference to an instance of a State subclass, which represents the current state of the Context.

    public class VendingMachine : IVendingMachineState
    {
        //Creating a variable to maintain the internal state
        public IVendingMachineState VendingMachineState { get; set; }

        //Initially the vending machine has NoMoneyState
        public VendingMachine()
        {
            VendingMachineState = new NoMoneyState();
        }

        // The Context Object allows changing the State of the object at runtime.
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            VendingMachineState.SelectProductAndInsertMoney(amount, productName);
            // Money has been inserted so Vending Machine's internal state changed to HasMoneyState
            if (VendingMachineState is NoMoneyState)
            {
                VendingMachineState = new HasMoneyState();
                Console.WriteLine($"VendingMachine internal state has been moved to {VendingMachineState.GetType().Name}");
            }
        }

        // The Context Object allows changing the State of the object at runtime.
        public void DispenseProduct()
        {
            VendingMachineState.DispenseProduct();
            // Product has been dispensed so vending Machine changed the internal state to NoMoneyState
            if (VendingMachineState is HasMoneyState)
            {
                VendingMachineState = new NoMoneyState();
                Console.WriteLine($"VendingMachine internal state has been moved to : {VendingMachineState.GetType().Name}");
            }
        }
    }
}
