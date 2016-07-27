using System;
using Nancy;
using System.Collections.Generic;
using Xunit;

namespace WordFinder
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Finder_FindWordDespiteCapitalization_2()
    {
      int testCounter = 2;
      int resultCounter = RepeatCounter.CountRepeats("shut", "Shut it down. Shut it down forever.");
      Assert.Equal(testCounter, resultCounter);
    }
  }
}
