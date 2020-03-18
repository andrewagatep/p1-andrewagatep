using System.Collections.Generic;
using MyPizza.Domain.Models;

namespace MyPizza.Client.Models
{
  public class UserViewModel
  {
    public List<User> UserList { get; set; }

    public User User { get; set; }

    public UserViewModel()
    {
      UserList = new List<User>();
    }
  }
}