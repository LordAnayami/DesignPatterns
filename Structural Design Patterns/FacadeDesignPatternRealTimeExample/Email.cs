using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternRealTimeExample
{
    public class Email
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            //Send Registration Successful Email to Customer
            Console.WriteLine("\nRegistration Email Send to Customer...");
            return true;
        }
    }
}
