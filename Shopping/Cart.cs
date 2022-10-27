using System;
using System.Collections.Generic;
using System.Text;
using Shopping;

namespace Shopping
{
    public class Cart
    {
        public List<Product> Products { get; set; }
        public void AddProduct(Product product)
        {
            Products.Add(product);

        }

    }
}
