using System.Collections.Generic;

namespace VendorOrders.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Price { get; private set; }

        private static List<Order> _instances = new List<Order> { };

        public Order(string title, string description, string date, int price)
        {
            Title = title;
            Description = description;
            Date = date;
            Price = price;
            _instances.Add(this);
        }

        public static List<Order> GetAll()
        {
            List<Order> fail = new List<Order> { };
            return fail;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }    
}