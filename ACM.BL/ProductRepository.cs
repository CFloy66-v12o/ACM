using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        

        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
            if (productId == 2)
            {
                product.Name = "Buzzsaw";
                product.Description = "12\" Buzzsaw";
                product.Price = 49.99m;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject}");
            Console.WriteLine($"Product: {product}");

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        

        
    }
}
