using System.Collections.Generic;
using System.Linq;
using MyPizza.Domain.Models;
using MyPizza.Storage.Database;

namespace MyPizza.Storage.Repositories
{
  public class PizzaRepository
  {
    private static readonly MyPizzaDbContext _db = new MyPizzaDbContext();

    public Pizza Get(string p_id)
    {
      return _db.Pizza.SingleOrDefault(p => p.Name == p_id);
    }

    public List<Pizza> Get()
    {
      return _db.Pizza.ToList();
    }

    // private MyPizzaDbContext _db;

    // public MyPizzaRepository(MyPizzaDbContext dbContext)
    // {
    //   _db = dbContext;
    // }

    // public IEnumerable<T> Read<T>() where T : class
    // {
    //   return _db.Set<T>();
    // }

    // public object CheckAccount(string user, string pass)
    // {
    //   return new object();
    // }
  }
}
