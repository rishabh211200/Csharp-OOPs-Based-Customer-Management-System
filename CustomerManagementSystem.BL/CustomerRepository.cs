using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class CustomerRepository
    {
        /* We are seperating t6he responsibilty of validating and saving the data 
           so that our Business Logic Models doesn't get impacted if any changes occur */

        ///<summary>
        /// retrieve one customer
        ///</summary>

        public Customer Retrieve(int customerId)
        {
            // Creates the instance of the customer class
            // Pass the customerID to Retrieve function.
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.FirstName = "Rishabh";
                customer.LastName = "Gupta";
                customer.EmailAddress = "rishabh211200@gmail.com";
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // code that saves the passed in customer
            return true;
        }
    }
}
