using System;
using Nancy;
using System.Collections.Generic;

namespace WordFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
      Post["/phrase_search"] =_=> {
        int CountResult = RepeatCounter.CountRepeats(Request.Form["phraseSearch"], Request.Form["wordSearch"]);
        return View["index.cshtml", CountResult];
      };
    }
  }
}
