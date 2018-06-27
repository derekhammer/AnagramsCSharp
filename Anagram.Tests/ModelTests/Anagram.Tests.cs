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
      string workingResult = newAnagram.SortWord();
      bool anagramResult = newAnagram.AnagramCheck("floabfu");
      //Assert
      Assert.IsTrue(anagramResult);
      // Console.WriteLine(workingResult);
    }
  }
}
