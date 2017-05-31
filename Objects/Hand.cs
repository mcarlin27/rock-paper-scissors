using System;
using System.Collections.Generic;

namespace HandProject.Objects
{
  public class Hand
  {
    private string _player1;
    private string _player2;

    public Hand (string input)
    {
      _player1 = input;
      _player2 = "Rock";
    }

    public string GetPlayer1()
    {
      return _player1;
    }
    public void SetPlayer1(string newPlayer1)
    {
      _player1 = newPlayer1;
    }
    public string GetPlayer2()
    {
      return _player2;
    }
    public void SetPlayer2(string newPlayer2)
    {
      _player2 = newPlayer2;
    }
    public static bool PlayGame(string player1, string player2)
    {
      string player1Input = player1;
      string player2Input = player2;
      if (player1Input == player2Input)
      {
        Console.WriteLine("Tie!");
        return true;
      }
      else if (player1Input == "Scissors")
      {
        Console.WriteLine("Player One loses");
        return false;
      }
      else if (player1Input == "Paper")
      {
        Console.WriteLine("Player One Wins!");
        return true;
      }
      else
      {
        Console.WriteLine("Something went wrong.");
        return false;
      }
    }
  }
}
