using System;
using System.Collections.Generic;
using System.Text;

namespace Getir.Models
{
    public class FoodItem
    {
        public int ProductID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int CategoryID { get; set; }
    }
}
