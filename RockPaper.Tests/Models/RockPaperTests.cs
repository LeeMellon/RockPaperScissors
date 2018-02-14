using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaper.Models;
using System.Collections.Generic;
using System;



namespace RockPaper.Tests
{
  [TestClass]
  public class RPSTest
  {
    [TestMethod]
    public void PlayerOneRock_PlayerOneWins_False()
    {
      RPS newGame = new RPS();
      newGame.PlayerOneRock("Paper");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);

    }
    [TestMethod]
    public void PlayerOneRock_PlayerOneWins_True()
    {
      RPS newGame = new RPS();
      newGame.PlayerOneRock("Scissors");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);

    }

    [TestMethod]
    public void PlayerOnePaper_PlayerOneWins_True()
    {
      RPS newGame = new RPS();
      newGame.PlayerOnePaper("Rock");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);
    }

    [TestMethod]
    public void PlayerOnePaper_PlayerOneWins_False()
    {
      RPS newGame = new RPS();
      newGame.PlayerOnePaper("Scissors");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);
    }

    [TestMethod]
    public void PlayerOneScissors_PlayerOneWins_True()
    {
      RPS newGame = new RPS();
      newGame.PlayerOneScissors("Paper");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 1);
    }

    [TestMethod]
    public void PlayerOneScissors_PlayerOneWins_False()
    {
      RPS newGame = new RPS();
      newGame.PlayerOneScissors("Rock");
      int POS = newGame.GetPlayerOneScore();
      Assert.AreEqual(POS, 0);
    }
  }
}
