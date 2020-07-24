using Microsoft.AspNetCore.Mvc;
using BakeryOrderTracker.Models;

namespace BakeryOrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}