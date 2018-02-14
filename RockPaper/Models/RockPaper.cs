using System.Collections.Generic;
using System;


namespace RockPaper.Models
{
    public class RPS
    {
      private int _playerOneScore;
      private int _playerTwoScore;
      private string _result;


      public void SetPlayerOneScore(int newScore)
      {
        _playerOneScore += newScore;
      }

      public void SetPlayerTwoScore(int newScore)
      {
        _playerTwoScore += newScore;
      }

      public int GetPlayerOneScore()
      {
        return _playerOneScore;
      }

      public int GetPlayerTwoScore()
      {
        return _playerTwoScore;
      }
      public string GetResult()
      {
        return _result;
      }

      public string PlayerOneRock(string PlayerTwoChoice)
      {
        // string Result = "";
        if (PlayerTwoChoice == "Rock")
        {
          _result = "Tie";
          } else if (PlayerTwoChoice == "Paper")
          {
            SetPlayerTwoScore(1);
            _result = "Player Two Wins!";
          } else {
            SetPlayerOneScore(1);
            _result = "Player One Wins!";
          }
          return _result;
        }

      public string PlayerOnePaper(string PlayerTwoChoice)
      {
        // string Result = "";
        if(PlayerTwoChoice == "Paper")
        {
          _result = "Tie";
        }else if (PlayerTwoChoice == "Rock")
        {
          SetPlayerOneScore(1);
          _result = "Player One Wins!";
        }else {
          SetPlayerTwoScore(1);
          _result = "Player Two Wins!";
        }
        return _result;
      }

      public string PlayerOneScissors(string PlayerTwoChoice)
      {
        // string Result = "";
        if (PlayerTwoChoice == "Scissors")
        {
          _result = "Tie";
          } else if (PlayerTwoChoice == "Paper")
          {
            SetPlayerOneScore(1);
            _result = "Player One Wins!";
          } else {
            SetPlayerTwoScore(1);
            _result = "Player Two Wins!";
          }
          return _result;
        }
    }
}
