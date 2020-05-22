using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Description { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }

    public Order(string description, double price, string date)
    {
      Description = description;
      Price = price;
      Date = date;
    }

  }
}