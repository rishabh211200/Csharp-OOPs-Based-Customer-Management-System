using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateAllValidProperties()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                Quantity = 1,
                ProductId = 123,
                PurchasePrice = 500
            };
            var expected = true;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingQuantity()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                ProductId = 123,
                PurchasePrice = 500
            };
            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingProductId()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                Quantity = 1,
                PurchasePrice = 500
            };
            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingPurchasePrice()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                Quantity = 1,
                ProductId = 123
            };
            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
