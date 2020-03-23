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

    [HttpGet]
    public IActionResult Store()
    {
      return View(new PizzaViewModel());
    }

    public IActionResult Choose()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Preset()
    {
      return View(new PizzaViewModel());
    }

    [HttpGet]
    public IActionResult Confirm()
    {
      return View(new PizzaViewModel());
    }
    
  }
}