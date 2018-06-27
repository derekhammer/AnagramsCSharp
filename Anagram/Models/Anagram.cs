using System.Collections.Generic;
using System;

namespace Anagramatical
{
  public class Anagram
  {
    private string _userWord;
    private static List<Anagram> _instances = new List<Anagram> {};

    public Anagram(string userword)
    {
      _userWord = userword;
    }

    public string GetUserWord()
    {
      return _userWord;
    }
    public void SetUserWord(string initialWord)
    {
      _userWord = initialWord;
    }
    public string SortUserWord()
    {
      string userWord = this.GetUserWord();
      string lowercase = userWord.ToLower();
      char[] letterArray = lowercase.ToCharArray();
      Array.Sort(letterArray);
      string result = String.Join("", letterArray);
      return result;
    }


    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }

  class Program
  {
    public static void Main()
    {

    }
  }
}
