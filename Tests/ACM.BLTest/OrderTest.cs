using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateValidOrderDate()
        {
            //--Arrange
            Order order = new Order()
            {
                OrderDate = DateTimeOffset.MaxValue
            };
            var expected = true;
            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateNullOrderdate()
        {
            //--Arrange
            Order order = new Order()
            {
                OrderDate = null
            };
            var expected = false;
            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
