using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class Customer
    {
        public int CustomerID { get; private set; } //any caller can get this ID but only this class can set it
        public string EmailAddress { get; set; }
        public string FirstName { get; set; } //Behind the code it is implementing Backing field automatically.

        //Static modifier
        // use static modifier to declare members that belong to a class
        // not a instance of the class.
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                //handling case when there is only last name it is to manage comma in output.
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Declaring property with backing field performing
        // Encapsulation here as some data is not necessarily meant to access.
        private string _lastName;   //Backing field- this field holds the data
        public string LastName // we can use internal also if we want to use it inside project only
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        /// <summary>
        /// Retrieve One Customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            //code that retrieves defined customer
            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        public List<Customer> Retrieve()
        {
            //code that retrieves defined customer
            return new List<Customer>();
        }


        /// <summary>
        ///  Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code to save current customer
            return true;
        }



        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid= false;
            return isValid;
        }

    }

