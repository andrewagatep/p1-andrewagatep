using MyPizza.Domain.Abstracts;

namespace MyPizza.Domain.Models
{
  public class User : APizzaComponent
  {
    public string Username {get; set;}
    public string Password {get; set;}
    // public string Email {get; set;}
    // public double Phone {get; set;}
  }
}