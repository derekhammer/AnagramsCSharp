using System.Collections.Generic;
using System;

//declares the namespace for use in testing
namespace Anagramatical
{
  //declares our Anagram Object class
  public class Anagram
  {
    //_userWord is to be compared to
    private string _userWord;
    //LIST OF STRINGS SO WE CAN COMPARE THEM JEEEZZZZZ
    private static List<string> _instances = new List<string> {};
    //Constructor for our Anagram Object, takes a string
    public Anagram(string userword)
    {
      _userWord = userword;
    }
    //allows us to access the private string _userWord for use
    public string GetWord()
    {
      return _userWord;
    }
    //useless in this program, would allow us to change the parameter of _userWord if needed.
    public void SetWord(string initialWord)
    {
      _userWord = initialWord;
    }
    //sorts whatever Anagram Object it is called on alphabetically and in lower case for comparison
    public string SortWord()
    {
      string userWord = this.GetWord();
      string lowercase = userWord.ToLower();
      char[] letterArray = lowercase.ToCharArray();
      Array.Sort(letterArray);
      string result = String.Join("", letterArray);
      return result;
    }
    //this method uses our SortWord method to check if _userWord (this) is an anagram of the additional words entered.
    public bool AnagramCheck(string checkWord)
    {
      char[] checkWordArray = checkWord.ToLower().ToCharArray();
      Array.Sort(checkWordArray);
      string joinedCheckWord = String.Join("", checkWordArray);
      return this.SortWord() == joinedCheckWord;
    }
    //dont use in this program, used to clear out _instances List in case a restart was desired
    public static void ClearAll()
    {
      _instances.Clear();
    }
    //This method takes in any number of additional words that will be compared against _userInput, once all words are collected it then runs AnagramCheck on _userInput (this) against each word.
    public void GrowList()
    {
      Console.WriteLine("Enter [Y] to add a new word to compare, or [N] to compare current items");
      string userInput = Console.ReadLine();
      if(userInput == "Y" || userInput == "y")
      {
        Console.WriteLine("Enter new word to compare:");
        string newWord = Console.ReadLine();
        _instances.Add(newWord);
        GrowList();
      }
      else if(userInput == "N" || userInput == "n")
      {
        foreach(string word in _instances)
        {
          if(this.AnagramCheck(word))
          {
            Console.WriteLine(word + " is an anagram of " + this.GetWord());
          }
        }
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      Console.WriteLine("First, enter a word.");
      string firstWord = Console.ReadLine();
      Anagram mainAnagram = new Anagram(firstWord);
      Console.WriteLine("Enter a word to check against "+mainAnagram.GetWord()+".");
      mainAnagram.GrowList();
    }
  }
}
