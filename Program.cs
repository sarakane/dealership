using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{

  public class Program
  {
    public static void Main()
    {

      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("1976 AMC Pacer", 400, 198000);
      // Car volkswagen = new Car();
      // volkswagen.MakeModel = "1974 Volkswagen Thing";
      // volkswagen.Price = 1100;
      // volkswagen.Miles = 368792;

      // Car yugo = new Car();
      // yugo.MakeModel = "1980 Yugo Koral";
      // yugo.Price = 700;
      // yugo.Miles = 56000;

      // Car ford = new Car();
      // ford.MakeModel = "1988 Ford Country Squire";
      // ford.Price = 1400;
      // ford.Miles = 239001;

      // Car amc = new Car();
      // amc.MakeModel = "1976 AMC Pacer";
      // amc.Price = 400;
      // amc.Miles = 198000;

      List<Car> cars = new List<Car>() { volkswagen, yugo, ford, amc };

      yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> carsMatchingSearch = new List<Car>();

      foreach (Car automobile in cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          carsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in carsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}