using System.Collections.Generic;
using MyPizza.Domain.Models;
using MyPizza.Storage.Repositories;

namespace MyPizza.Client.Models
{
  public class OrderViewModel
  {
    private static readonly StoreRepository str = new StoreRepository();
    private static readonly PizzaRepository pr = new PizzaRepository();
    private static readonly SizeRepository sir = new SizeRepository();


    // [Required]
    public long Storeid {get; set;}
    public long Pizzaid {get; set;}
    public long Sizeid {get; set;}
    
    public List<Store> Store{get; set;}
    public List<Pizza> Pizza{get; set;}
    public List<Size> Size{get; set;}

    public OrderViewModel()
    {
      Store = str.Get();
      Pizza = pr.Get();
      Size = sir.Get();
    }
  }
}