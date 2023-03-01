using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class DetailsController : Controller
  {
    [HttpGet("/trips/{id}/details")]
    public ActionResult detailsIndex()
    {
      List<Details> details = Details.GetAll();
      return View(details);
    }

    // [HttpGet("/trips/{id}")]
    // public ActionResult Create(string details)
    // {
    //   return View();
    // }

    [HttpPost("/trips/{TripId}")]
    public ActionResult CreateDetails(string details, int TripId)
    {
      Details newDetails = new Details(details, TripId);
      return RedirectToAction("Index"); 
    }
  }
}
