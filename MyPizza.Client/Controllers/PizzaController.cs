using Microsoft.AspNetCore.Mvc;
using MyPizza.Client.Models;

namespace MyPizza.Client.Controllers
{
  public class PizzaController : Controller
  {
    [HttpGet]
    public IActionResult Read()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View(new PizzaViewModel());
    }

    [HttpPost]
    public IActionResult Create(PizzaViewModel pizzaViewModel)
    {
      return View();
    }
  }
}