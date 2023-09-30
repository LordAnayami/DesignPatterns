using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternRealTimeExample
{
    public class CustomerDataAccessLayer
    {
        public bool SaveCustomer(Customer customer)
        {
            //Save the Customer in the Database
            Console.WriteLine("\nCustomer Saved into the Database...");
            return true;
        }
    }
}
