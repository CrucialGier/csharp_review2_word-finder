using System;
using Nancy;
using Finder.Objects;
using System.Collections.Generic;

namespace Finder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
      Post["/phrase_search"] =_=> {
        
      }
    }
  }
}
