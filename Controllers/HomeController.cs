using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult DefaultText()
    { 
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Noun = "Noun";
      myWordVariable.Verb = "Verb";
      myWordVariable.Adjective = "Adjective";
      myWordVariable.Adverb = "Adverb";
      return View(myWordVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLib(string noun, string verb, string adjective, string adverb)
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Noun = noun;
      myWordVariable.Verb = verb;
      myWordVariable.Adjective = adjective;
      myWordVariable.Adverb = adverb;
      return View(myWordVariable);
    }
  }
}