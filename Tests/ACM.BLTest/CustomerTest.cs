using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //We are going to follow the method of Arrange Act and Assert
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Rishabh",
                LastName = "Gupta"
            };
            string expected = "Gupta, Rishabh";
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer()
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";      
            //--Act
            string actual = customer.FullName;
            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            
            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                EmailAddress = "frodo.baggins@gmail.com"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //--Arrange
            var customer = new Customer()
            {
                LastName = "Baggins"
            };
            var expected = false;


            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}