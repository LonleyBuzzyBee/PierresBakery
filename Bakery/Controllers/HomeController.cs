using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // [HttpGet("/photos")]
    // public ActionResult Photos()
    // {
    //   return View();
    // }

  }
}