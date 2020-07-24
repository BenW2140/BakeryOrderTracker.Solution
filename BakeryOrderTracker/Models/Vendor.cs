using System.Collections.Generic;

namespace BakeryOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    // public List<Order> Orders { get; set }
    public Vendor(string name)
    {
      Name = name;
      _vendors.Add(this);
      Id = _vendors.Count;
      // Orders = new List<Order> {};
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
  }
}