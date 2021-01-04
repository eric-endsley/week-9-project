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

        public Order(string title, string description, string date, int price)
        {
            Title = title;
            Description = description;
            Date = date;
            Price = price;
             _instances.Add(this);
            Id = _instances.Count + 1;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }    
}