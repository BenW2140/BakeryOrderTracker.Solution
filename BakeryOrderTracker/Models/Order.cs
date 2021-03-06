using System.Collections.Generic;

namespace BakeryOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order> {};
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }
    public Order(string name, string description, float price, string date)
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
      Id = _orders.Count;
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }
    public static List<Order> GetAll()
    {
      return _orders;
    }
    public static Order Find(int id)
    {
      return _orders[id - 1];
    }
  }
}