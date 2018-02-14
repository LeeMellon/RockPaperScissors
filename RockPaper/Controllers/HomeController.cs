using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RockPaper.Models;
using System;

namespace RockPaper.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        RPS newGame = new RPS();
        return View(newGame);
      }

      [HttpPost("/gameResult")]
      public ActionResult GameResult()
      {
        string POChoice = Request.Form["PlayerOne"];
        string PTChoice = Request.Form["PlayerTwo"];
        RPS newGame = new RPS();
        if (POChoice == "Rock"){
          newGame.PlayerOneRock(PTChoice);
        } else if (POChoice == "Paper"){
          newGame.PlayerOnePaper(PTChoice);
        } else if (POChoice == "Scissors"){
          newGame.PlayerOneScissors(PTChoice);
        }

        return View("Index", newGame);
      }

    }
}
