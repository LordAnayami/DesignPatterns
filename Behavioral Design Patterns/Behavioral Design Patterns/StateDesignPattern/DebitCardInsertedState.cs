﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    // Concrete States implement various behaviors, associated with a state of the Context Object.
    // The following Concrete State class implement behavior when the ATM State i.e. Context Objec State is DebitCardInsertedState
    public class DebitCardInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert the Debit Card, as the Debit card is already there ");
        }

        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card is ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }
}
