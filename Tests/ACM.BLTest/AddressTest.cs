using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void ValidPostalCode()
        {
            //--Arrange
            Address address = new Address()
            {
                PostalCode = "110053"
            };
            var expected = true;
            //--Act

            var actual = address.Validate();
            //--Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NullPostalCode()
        {
            //--Arrange
            Address address = new Address()
            {
                PostalCode = null
            };
            var expected = false;
            //--Act

            var actual = address.Validate();
            //--Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
