using ContosoPets.Api.Models;
using System.Linq;
using System;

namespace ContosoPets.Api.Data
{
  public static class SeedData
  {
    public static void Initialize(ContosoPetsContext context)
    {
      if (!context.Products.Any())
      {
        Console.WriteLine("No Products");

        context.Products.AddRange(
          new Product
          {
            Id = 0,
            Name = "Squeaky Bone",
            Price = 20.99m
          },
          new Product
          {
            Id = 0,
            Name = "Knotted Rope",
            Price = 12.99m
          }
        );

        context.SaveChanges();
      }
      else Console.WriteLine("With Products");
    }
  }
}