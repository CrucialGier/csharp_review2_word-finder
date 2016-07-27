using System;
using Nancy;
using System.Collections.Generic;
using Xunit;

namespace WordFinder
{
  public class RepeatCounter
  {
    public static int CountRepeats(string Word, string Phrase)
    {
      int InstancesFound = 0;
      string phraseBare = "";
      foreach (char symbol in Phrase)
      {
        if (!char.IsPunctuation(symbol))
        {
          phraseBare += symbol;
        }
      }
      phraseBare = phraseBare.ToLower();
      string[] phraseArray = phraseBare.Split(' ');
      foreach (string word in phraseArray)
      {
        if (word == Word)
        {
          InstancesFound++;
        }
      };
      return InstancesFound;
    }

  }
}
