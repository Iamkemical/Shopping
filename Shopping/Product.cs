using System;
using System.Collections.Generic;

namespace Shopping
{
    public class Product
    {
        public Code ItemCode { get; set; }
        public decimal UnitPrice { get; set; }
       
    }

    public enum Code
    {
        A, B, C, D, E
    }
    
}
