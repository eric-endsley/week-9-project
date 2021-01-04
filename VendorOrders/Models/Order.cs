using System.Collections.Generic;

namespace VendorOrders.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Price { get; private set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
    }

    Order() 
}