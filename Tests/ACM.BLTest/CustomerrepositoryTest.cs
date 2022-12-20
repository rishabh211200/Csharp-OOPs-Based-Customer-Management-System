using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerrepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)  // -----> here
            {
                //as we know we can't set customer id from outside 
                //so it will give error
                // we had created a constructor which takes customer
                // id as parameter so we will be going to pass it as parameter
                //customerId = 1,
                EmailAddress = "rishabh211200@gmail.com",
                FirstName = "Rishabh",
                LastName = "Gupta"
            };

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            /*
             * If we are going to assert expected and actual like this then it is 
             * not going to pass because these both are 2 different instances of customer
             * and they are not referencing to same object so they can't be equal
             * 
             * how we can solve this issue?
             * We will explicitly checking the properties so that we can verify that they are 
             * same or not
            */
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FullName, actual.FullName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

        }
        [TestMethod]
        public void RetrieveNullCustomer()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(2)
            {
                EmailAddress = "ritik211200@gmail.com",
                FirstName = "Ritik",
                LastName = "Gupta"
            };

            //--Act
            var actual = customerRepository.Retrieve(3);

            //--Assert
            //As we know that customer id 3 doesn't exist so we compared with null
            Assert.AreEqual(null, actual.FirstName);
            Assert.AreEqual(null, actual.LastName);
            Assert.AreEqual(null, actual.FullName);
            Assert.AreEqual(null, actual.EmailAddress);


        }
    }
}
