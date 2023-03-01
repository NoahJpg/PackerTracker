using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Details
  {
    public string TripDetails { get; set; }
    public int Id { get; }
    public int TripId { get; } 
    private static List<Details> _instances = new List<Details> { };

    public Details(string details, int tripId)
    {
      TripDetails = details;
      TripId = tripId;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Details> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Details Find(int searchId)
    {
      return _instances[searchId-1];
    }

    //find by trip id()
    //loop through instances 
    //return detail object
    //pass into view
  }
}