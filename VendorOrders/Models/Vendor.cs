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
        }

        public static List<Vendor> GetAll()
        {
            List<Vendor> fail = new List<Vendor> { };
            return fail;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}