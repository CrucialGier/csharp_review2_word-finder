using System;
using Nancy;
using WordFinder.Objects;
using System.Collections.Generic;

namespace Finder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
    }
  }
}
