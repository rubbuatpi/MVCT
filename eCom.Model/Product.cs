using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCom.Model
{
    public class Product
    {
        public Int32 Product_ID { get; set; }
        public String Product_Name { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
