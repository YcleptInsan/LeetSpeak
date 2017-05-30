using Nancy;
using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      Post["/output"] = _ =>{
        string input = Request.Form["user_input"];
        Console.WriteLine("1,"  + input);
        Translate newSentence = new Translate(input);
        Console.WriteLine("2," + newSentence.GetuserInput());
        string result = newSentence.translator(input);
        Console.WriteLine("3," + result);
        return View["output.cshtml", result];
      };
    }
  }
}
