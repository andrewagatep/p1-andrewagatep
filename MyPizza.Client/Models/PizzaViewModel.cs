using System.Collections.Generic;
using MyPizza.Domain.Models;
using MyPizza.Storage.Repositories;

namespace MyPizza.Client.Models
{
  public class PizzaViewModel
  {
    private static readonly PizzaRepository pr = new PizzaRepository();
    private static readonly SizeRepository sir = new SizeRepository();
    private static readonly StoreRepository str = new StoreRepository();

    public string PizzaName {get; set;}
    public string SizeName {get; set;}
    public string StoreName {get; set;}
    
    public long PizzaId {get; set;}
    public long SizeId {get; set;}
    public double Price {get; set;}
    //public long Sizeid {get; set;}

    public List<Pizza> Pizza {get; set;}
    public List<Size> Size {get; set;}
    public List<Store> Store {get; set;}
    public PizzaViewModel()
    {
      Pizza = pr.Get();
      Size = sir.Get();
      Store = str.Get();
    }    

    //private PizzaBoxRepository pbr;
    // public Pizza View Model(PizzaBoxRepository repository)
    // {
    //   pbr = repository;
    // }
    // public List<Crust> CrustList { get; set; }
    // public List<Size> SizeList { get; set; }
    // public List<Topping> ToppingList { get; set; }

    // public Crust Crust { get; set; }
    // public Size Size { get; set; }
    // public List<Topping> Toppings { get; set; }

    // public PizzaViewModel()
    // {
    //   CrustList = new List<Crust>();
    //   SizeList = new List<Size>();
    //   ToppingList = new List<Topping>();
    // }


  }
}