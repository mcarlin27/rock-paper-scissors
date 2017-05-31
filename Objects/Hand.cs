using System;
using System.Collections.Generic;

namespace HandProject.Objects
{
  public class Hand
  {
    private string _player1;
    private string _player2;
    private string _computer;
    private string _vsai;

    public Hand (string player1Input, string player2Input)
    {
      _player1 = player1Input;
      _player2 = player2Input;
      _computer = "";
      _vsai = "";
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
    public string GetComputer()
    {
      return _computer;
    }
    public void SetComputer(string computer)
    {
      _computer = computer;
    }
    public string GetVsAI()
    {
      return _vsai;
    }

    public static string PlayGame(string player1, string player2)
    {
      string player1Input = player1;
      string player2Input = player2;

      if (player1Input == player2Input)
      {
        Console.WriteLine("Tie!");
        return "Tie!"; //true
      }
      else if (player1Input == "Scissors" && player2Input != "Rock")
      {
        Console.WriteLine("You Win!");
        return "Player One Wins!"; //true
      }
      else if (player1Input == "Paper" && player2Input != "Scissors")
      {
        Console.WriteLine("Player One Wins!");
        return "Player One Wins!"; //true
      }
      else if (player1Input == "Rock" && player2Input != "Paper")
      {
        Console.WriteLine("Player One Wins!");
        return "Player One Wins!"; //true
      }
      else
      {
        Console.WriteLine("Player Two Wins!");
        return "Player Two Wins!"; //false
      }
    }
    public void VsAI(string player)
    {
      string player1Input = player;

      var options = new List<string>{"Rock", "Paper", "Scissors"};
      int randomInt = new Random().Next(0,3);

      string output = options[randomInt];
      _computer = output;

      if (player1Input == output)
      {
        Console.WriteLine("Tie!");
        _vsai = "Tie!"; //true
      }
      else if (player1Input == "Scissors" && output != "Rock")
      {
        Console.WriteLine("Player One Wins!");
        _vsai = "You Win!"; //true
      }
      else if (player1Input == "Paper" && output != "Scissors")
      {
        Console.WriteLine("You Win!");
        _vsai = "You Win!"; //true
      }
      else if (player1Input == "Rock" && output != "Paper")
      {
        Console.WriteLine("You Win!");
        _vsai = "You Win!"; //true
      }
      else
      {
        Console.WriteLine("Computer Wins!");
        _vsai = "Computer Wins!"; //false
      }
    }
  }
}
