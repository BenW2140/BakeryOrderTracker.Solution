using System.Collections.Generic;

namespace BakeryOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order> {};
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
    public static Vendor Find(int id)
    {
      return _vendors[id - 1];
    }
  }
}