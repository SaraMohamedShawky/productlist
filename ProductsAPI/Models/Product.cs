using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductCatgeory { get; set; }
        public decimal ProductPrice { get; set; }
    }
}