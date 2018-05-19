using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVCCRUD.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        [DisplayName("Quantity")]
        public int Count { get; set; }
    }
}