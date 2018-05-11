using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eCom.Model
{
    public class Customer
    {
        public Int32 Customer_ID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }

        public String Location { get; set; }
    }
}
