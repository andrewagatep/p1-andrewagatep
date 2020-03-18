using Microsoft.AspNetCore.Mvc;
using MyPizza.Client.Models;

namespace MyPizza.Client.Controllers
{
  public class UserController : Controller
  {
    [HttpGet]
    public IActionResult Read()
    {
      return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
      return View(new UserViewModel());
    }

    [HttpPost]
    public IActionResult Register(UserViewModel userViewModel)
    {
      return View();
    }
  }
}