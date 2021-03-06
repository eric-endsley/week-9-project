using System.Collections.Generic;

namespace VendorOrders.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public  List<Order> Orders { get; set; }
        public int Id { get; }
        private static List<Vendor> _instances = new List<Vendor> { };

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor Find(int inputId)
        {
            return _instances[inputId - 1];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}