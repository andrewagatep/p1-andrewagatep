using MyPizza.Domain.Abstracts;

namespace MyPizza.Domain.Models
{
  public class Cart
  {
    public long Id {get; set;}
    public long Pizzaid {get; set;}
    public long Sizeid {get; set;}
    public double Price {get; set;}
    public long OrderId {get; set;}
    
  }
}