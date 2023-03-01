using PackerTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Letter() 
    {
      return View();
    }
  }
}