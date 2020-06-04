using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Order
  {
    public int Id { get; }
    public int VendorId { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }


    public Order(string description, int price, string date, int vendorId)
    {

      Description = description;
      Price = price;
      Date = date;
      VendorId = vendorId;
      _instances.Add(this);

      Id = _instances.Count;

    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static List<Order> GetAllByVendorId(int vendorId)
    {

      return _instances.Where(order => order.VendorId == vendorId).ToList();
    }
        public static Order Find(int searchId)
    {
      
      return _instances[searchId - 1];
    }
    public static void Delete(int Id)
    {

      Order._instances.RemoveAt(Id-1);      
    }
  }
}