using MyPizza.Storage.Database;
using MyPizza.Domain.Models;
using System.Linq;
using System.Collections.Generic;

namespace MyPizza.Storage.Repositories
{
  public class StoreRepository
  {
    private static readonly MyPizzaDbContext _db = new MyPizzaDbContext();

    public Store Get(string st_id)
    {
      return _db.Store.SingleOrDefault(st => st.Name == st_id);
    }

    public List<Store> Get()
    {
      return _db.Store.ToList();
    }

  }
}