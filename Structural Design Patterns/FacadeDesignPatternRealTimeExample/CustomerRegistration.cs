using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternRealTimeExample
{
    public class CustomerRegistration
    {
        public bool RegisterCustomer(Customer customer)
        {
            //Step1: Validate the Customer
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);

            //Step1: Save the Customer Object into the database
            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);

            //Step3: Send the Registration Email to the Customer
            Email email = new Email();
            email.SendRegistrationEmail(customer);

            return true;
        }
    }
}
