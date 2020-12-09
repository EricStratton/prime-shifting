using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeShifting.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeShifting.Tests
{
  [TestClass]
  public class PrimeTests 
  {
    [TestMethod]
    public void GetRange_CreatesListOfIntegersUpToUserInput_ItemList()
    {
        Prime testPrime = new Prime();
        List<int> testNumberList = new List<int>() { 2,3,4 };
        List<int> userInput = testPrime.GetRange(4);
        foreach(int number in userInput) { Console.WriteLine(number); }
        CollectionAssert.AreEqual(testNumberList, userInput);
    }

    [TestMethod]
    public void GetPrime_CreatesFilteredListFromRangeList_FilteredList()
    {
        Prime testPrime = new Prime();
        List<int> expectedList = new List<int>() { 2,3,5,7,11,13,17,19 };
        List<int> userInput = testPrime.GetRange(20);
        foreach(int number in userInput) { Console.WriteLine(number); }
        List<int> newList = testPrime.GetPrime(userInput);
        foreach(int number in newList) { Console.WriteLine(number); }
        CollectionAssert.AreEqual(expectedList, newList);
    }
  }
}
