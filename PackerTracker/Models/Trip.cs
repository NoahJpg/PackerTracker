using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Trip
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Trip> _instances = new List<Trip> { };

    public Trip(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Trip> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Trip Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}