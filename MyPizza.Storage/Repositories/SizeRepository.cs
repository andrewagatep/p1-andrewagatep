using MyPizza.Storage.Database;
using MyPizza.Domain.Models;
using System.Linq;
using System.Collections.Generic;

namespace MyPizza.Storage.Repositories
{
  public class SizeRepository
  {
    private static readonly MyPizzaDbContext _db = new MyPizzaDbContext();

    public Size Get(string si_id)
    {
      return _db.Size.SingleOrDefault(si => si.Name == si_id);
    }

    public List<Size> Get()
    {
      return _db.Size.ToList();
    }

  }
}