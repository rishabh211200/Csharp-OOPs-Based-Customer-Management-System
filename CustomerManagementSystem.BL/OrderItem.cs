using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        /// <summary>
        /// Retrieve One Order
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            //code that retrieves defined order
            return new OrderItem();
        }
        /// <summary>
        /// Retrieve all orders
        /// </summary>
        public List<OrderItem> Retrieve()
        {
            //code that retrieves defined customer
            return new List<OrderItem>();
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
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;
            return isValid;
        }
    }
}
