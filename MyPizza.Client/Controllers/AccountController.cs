using Microsoft.AspNetCore.Mvc;
using MyPizza.Client.Models;

namespace MyPizza.Client.Controllers
{
  public class AccountController : Controller
  {
    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult Login(AccountViewModel account)
    {
      if(!ModelState.IsValid)
      {
        return View(account);
      }

      if(account.User)
      {
        return View("User");
      }

      return View("Store");
    }

    public IActionResult Logout()
    {
      return View();
    }
  }
}