using System;
using Nancy;
using System.Collections.Generic;
using Xunit;

namespace WordFinder.Objects
{
  public class Finder
  {
    private string _word;
    private string _phrase;
    private int _instancesFound;

    public void SetWord(string word)
    {
      _word = word;
    }
    public string GetWord()
    {
      return _word;
    }

    public void SetPhrase(string phrase)
    {
      _phrase = phrase;
    }
    public string GetPhrase()
    {
      return _phrase;

    public int GetInstancesFound()
    {
      return _instancesFound;
    }
  }
}
