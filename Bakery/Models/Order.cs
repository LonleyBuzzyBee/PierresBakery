using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order(string description, int price, string date)
    {

      Description = description;
      _instances.Add(this);
      Price = price;
      _instances.Add(this);
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;

    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    // public static Order Find(int searchId)
    // {
    //   return _instances[searchId - 1];
    // }

  }
}