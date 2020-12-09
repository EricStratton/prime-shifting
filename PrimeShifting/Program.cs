using System;
using System.Collections.Generic;
using System.Linq;
using PrimeShifting.Models;

namespace PrimeShifting
{
  public class Program
  {
    public static void Main()
    {
      Prime newPrime = new Prime();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("Enter a number and I'll return all Prime Numbers up to that value: ");
      Console.ResetColor();
      string stringUserNumber = Console.ReadLine();
      int userNumber = int.Parse(stringUserNumber);

      List<int> rangeList = newPrime.GetRange(userNumber);

      List<int> primeList = newPrime.GetPrime(rangeList);

      foreach (int prime in primeList)
      {
        Console.WriteLine(prime);
      }

    }
  }
}