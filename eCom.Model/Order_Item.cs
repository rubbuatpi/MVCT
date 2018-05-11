using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCom.Model
{
    public class Order_Item
    {

        public Int32 Order_Item_ID { get; set; }
        public Int32 Order_ID { get; set; }
        public Int32 Product_ID { get; set; }

        public Int32 Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
