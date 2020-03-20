using Microsoft.AspNetCore.Mvc;

namespace MyPizza.Client.Controllers
{
  public class StoreController : Controller
  {
    [HttpGet]
    public IActionResult History()
    {
      return View("Store");
    }

  }
}