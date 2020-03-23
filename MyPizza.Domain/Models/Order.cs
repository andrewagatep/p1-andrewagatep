using System;
using System.Collections.Generic;

namespace MyPizza.Domain.Models
{
  public class Order
  {
    public long Id {get; set;}
    public double Total {get; set;}
    public List<Cart> Cart {get; set;}

    public Order()
    {
      Id = DateTime.Now.Ticks;
    }
  }
}