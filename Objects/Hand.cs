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
    public static string PlayGame(string player1)
    {
      string player1Input = player1;
      Console.WriteLine(player1Input);
      return player1Input;
    }
  }
}
