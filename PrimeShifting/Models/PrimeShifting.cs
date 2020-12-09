using System.Collections.Generic;
using System.Linq;

namespace PrimeShifting.Models
{
  public class Prime 
  {

    public List<int> GetRange(int userInput)
    {
      IEnumerable<int> numberEnumerable = Enumerable.Range(2, userInput - 1);
      List<int> numberList = numberEnumerable.ToList();
      return numberList;
    }

    public List<int> GetPrime(List<int> numberList)
    {
      List<int> primeList = new List<int>() {};
      foreach (int num in numberList)
      {
        if (num == 2 || num == 3 || num == 5 || num == 7 )
        {
          primeList.Add(num);
        }
        else if (!(num % 2 == 0) && !(num % 3 == 0) && !(num % 5 == 0) && !(num % 7 == 0)) 
        {
          primeList.Add(num);
        }
      }
      return primeList;
    }
  }
}