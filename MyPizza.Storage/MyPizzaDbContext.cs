using Microsoft.EntityFrameworkCore;
using MyPizza.Domain.Models;

namespace MyPizza.Storage.Database
{
  public class MyPizzaDbContext : DbContext
  {
    public DbSet<Store> Store {get; set;}
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Topping> Topping { get; set; }
    public DbSet<User> User {get; set;}
    // public DbSet<Order> Order {get; set;}

    // public MyPizzaDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;database=mypizzadb;user id=sa;password=Password12345");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasKey(u => u.Id);
      builder.Entity<Store>().HasKey(st => st.Id);
      builder.Entity<Pizza>().HasKey(p => p.Id);
      builder.Entity<Size>().HasKey(si => si.Id);
      builder.Entity<Crust>().HasKey(c => c.Id);
      // builder.Entity<Toppings>().HasKey(si => si.Toppingsid);
      //builder.Entity<Order>().HasKey(o => o.Id);

      // builder.Entity<Store>().HasMany(p => p.Sizes).WithOne(si => si.Store).HasForeignKey(si => si.Sizeid);
      builder.Entity<Pizza>().HasMany(p => p.Sizes).WithOne(si => si.Pizza);
      builder.Entity<Pizza>().HasMany(p => p.Crusts).WithOne(c => c.Pizza);
      // builder.Entity<Pizza>().HasMany(p => p.PizzaToppings).WithOne(si => si.Pizza).HasForeignKey(si => si.Sizeid);
      
      builder.Entity<User>().HasData(new User[]
      {
        new User() {Id = 1, Name = "Pizza Hut"},
        new User() {Id = 2, Name = "Domino's"}
      });

      builder.Entity<Store>().HasData(new Store[]
      {
        new Store() {Id = 1, Name = "Pizza Hut"},
        new Store() {Id = 2, Name = "Domino's"}
      });

      builder.Entity<Pizza>().HasData(new Pizza[]
      {
        new Pizza() {Id= 1, Name = "Cheese Pizza", Sizeid = 1, Crustid = 1, Price = 5.00, Storeid = 1},
        new Pizza() {Id= 2, Name = "Pepperoni Pizza", Sizeid = 2, Crustid = 2, Price = 6.50, Storeid = 1}
      });

      builder.Entity<Size>().HasData(new Size[]
      {
        new Size() {Id = 1, Name = "Small"},
        new Size() {Id = 2, Name = "Medium"},
        new Size() {Id = 3, Name = "Large"}
      });

      builder.Entity<Crust>().HasData(new Crust[]
      {
        new Crust() {Id = 1, Name = "Cheese Stuffed"},
        new Crust() {Id = 2, Name = "Thin Crust"}
      });
      
    }
  }
}
