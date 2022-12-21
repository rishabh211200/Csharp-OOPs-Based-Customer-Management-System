using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product Class
            // Pass in the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product
            //Temporary hard-coded values to return
            //a populated product
            if (productId == 1)
            {
                product.ProductName = "Rich dad Poor dad Book";
                product.ProductDescription = "Hard cover book paperback 416 gsm";
                product.CurrentPrice = 400.32M;
            }
            return product; 
        }
        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        
        public bool Save (Product product)
        {
            //Code that saves the passed in product
            return true;
        }

    }
}
