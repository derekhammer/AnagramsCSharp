using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagramatical;
using System;

namespace Anagramatical.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void SetUserWord_ReturnsSortedArray_True()
    {
      //Assign
      string newWord = "Buffalo";
      Anagram newAnagram = new Anagram(newWord);
      string expectedResult = "abfflou";


      //Act
      string workingResult = newAnagram.SortUserWord();

      //Assert
      Assert.AreEqual(expectedResult, workingResult);
      Console.WriteLine(workingResult);
    }
  }
}
