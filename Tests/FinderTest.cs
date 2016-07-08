using System;
using Nancy;
using System.Collections.Generic;
using Xunit;

namespace WordFinder.Objects
{
  public class FinderTest
  {
    [Fact]
    public void Finder_FindWordInSentence_2()
    {
      Finder newTestFinder = new Finder();
      newTestFinder.SetWord("it");
      newTestFinder.SetPhrase("Shut it down. Shut it down forever.");
      Assert.Equal(2, newTestFinder.FindWord());
    }
    [Fact]
    public void Finder_FindWordDespitePunctuation_2()
    {
      Finder newTestFinder = new Finder();
      newTestFinder.SetWord("down");
      newTestFinder.SetPhrase("Shut it down. Shut it down forever.");
      Assert.Equal(2, newTestFinder.FindWord());
    }
    [Fact]
    public void Finder_FindWordDespiteCapitalization_2()
    {
      Finder newTestFinder = new Finder();
      newTestFinder.SetWord("shut");
      newTestFinder.SetPhrase("Shut it down. Shut it down forever.");
      Assert.Equal(2, newTestFinder.FindWord());
    }
  }
}
