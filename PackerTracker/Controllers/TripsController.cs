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
      List<Trip> allTrips = Trip.GetAll();
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
      Trip foundTrip = Trip.Find(id);
      return View(foundTrip);
      // replace with detail object
    }

    [HttpPost("/trips")]
    public ActionResult Create(string description, string details)
    {
      Trip myTrip = new Trip(description);
      Details myDetails = new Details(details, myTrip.Id);
      return RedirectToAction("Index"); 
    }

    [HttpPost("/trips/delete")]
    public ActionResult DeleteAll()
    {
      Trip.ClearAll();
      return View();
    }

    // [HttpGet("trips/{id}/details")]
    // public ActionResult Details(string details)
    // {
    //   return View();
    // }
   
  }
}