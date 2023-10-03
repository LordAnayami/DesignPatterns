﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Console.WriteLine("Requested Amount 4600");
            atm.Withdraw(4600);

            Console.WriteLine("\nRequested Amount 1900");
            atm.Withdraw(1900);

            Console.WriteLine("\nRequested Amount 600");
            atm.Withdraw(600);

            Console.WriteLine("\nRequested Amount 750");
            atm.Withdraw(750);

            Console.Read();
        }
    }
}
