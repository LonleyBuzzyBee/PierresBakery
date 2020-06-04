using System.Collections.Generic;

namespace Bakery.Models
{
      public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public int Id { get; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Vendor(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }
        public static Vendor Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public List<Order> GetOrders()
        {
           return Order.GetAllByVendorId(Id);
        }
  }
}