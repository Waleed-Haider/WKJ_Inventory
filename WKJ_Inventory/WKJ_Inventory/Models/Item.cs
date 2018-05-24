using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WKJ_Inventory.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
    }
}