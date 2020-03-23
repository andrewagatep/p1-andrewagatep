using Microsoft.AspNetCore.Mvc;
using MyPizza.Client.Models;

namespace MyPizza.Client.Controllers
{
  public class OrderController : Controller
  {
    public IActionResult Pizza()
    {
      return View(new OrderViewModel());
    }

    
  }
}