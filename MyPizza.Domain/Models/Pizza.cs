using System.Collections.Generic;
using MyPizza.Domain.Abstracts;

namespace MyPizza.Domain.Models
{
  public class Pizza : APizzaComponent
  {
    public long Storeid {get; set;}
    public List<Size> Sizes {get; set;}
    public List<Crust> Crusts {get; set;}
    public double Price {get; set;}

    //seed
    public long Sizeid {get; set;}
    public long Crustid {get; set;}

  }
}