using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrieve One Order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //code that retrieves defined order
            return new Order();
        }
        /// <summary>
        /// Retrieve all orders
        /// </summary>
        public List<Order> Retrieve()
        {
            //code that retrieves defined customer
            return new List<Order>();
        }
        /// <summary>
        ///  Saves the current order
        /// </summary>
        /// <returns></returns>        
        public bool Save()
        {
            //Code to save current customer
            return true;
        }
        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
