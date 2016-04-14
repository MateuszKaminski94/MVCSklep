using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MateuszowSKYSklep.Models
{
    public class CartItem
    {
        public Game Game { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}