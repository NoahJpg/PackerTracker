using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class TripsController : Controller
  {
    [HttpGet("/trips")]
    public ActionResult index()
    {
      List<Trips> allTrips = Trips.GetAll();
      return View(allTrips);
    }

    [HttpGet("/trips/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/trips/{id}")]
    public ActionResult Show(int id)
    {
      Trips foundTrip = Trips.Find(id);
      return View(foundTrip);
    }

    [HttpPost("/trips/delete")]
    public ActionResult DeleteAll()
    {
      Trips.ClearAll();
      return View();
    }


  }
}