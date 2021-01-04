using System.Collections.Generic;

namespace VendorOrders.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int Price { get; private set; }

        public Order(string title, string description, string date, int price)
        {
            Title = "fail";
            Description = "fail";
            Date = "fail";
            Price = 13;
        }
    }    
}