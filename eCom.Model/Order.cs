using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCom.Model
{
    public class Order
    {
        public Int32 Order_ID { get; set; }
        public DateTime Order_Date { get; set; }

        public Int32 Customer_ID { get; set; }

        public ICollection<Order_Item> Order_Items { get; set; }
    }
}
