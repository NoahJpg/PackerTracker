using ProjectName.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
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