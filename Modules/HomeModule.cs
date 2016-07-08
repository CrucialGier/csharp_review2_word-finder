using System;
using Nancy;
using WordFinder.Objects;
using System.Collections.Generic;

namespace WordFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
      Post["/phrase_search"] =_=> {
        Finder newFinder = new Finder();
        newFinder.SetWord(Request.Form["wordSearch"]);
        newFinder.SetPhrase(Request.Form["phraseSearch"]);
        newFinder.FindWord();
        return View["index.cshtml", newFinder.GetInstancesFound()];
      };
    }
  }
}
