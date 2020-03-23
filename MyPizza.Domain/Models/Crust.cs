using MyPizza.Domain.Abstracts;

namespace MyPizza.Domain.Models
{
  public class Crust : APizzaComponent
  {
    public Pizza Pizza {get; set;}

  }
}