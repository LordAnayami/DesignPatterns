using System;
namespace FacadeDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Instance of Customer Class
            Customer customer = new Customer()
            {
                Name = "Pranaya",
                Email = "info@dotnettutorials.net",
                MobileNumber = "1234567890",
                Address = "BBSR, Odisha, India"
            };

            //Using Facade Class
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.RegisterCustomer(customer);

            Console.ReadKey();
        }
    }
}