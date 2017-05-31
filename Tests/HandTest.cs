using Xunit;
using System.Collections.Generic;

namespace HandProject.Objects
{
  public class HandTest
  {
    [Fact]
    public void PlayGame_Player1Input_true()
    {
      //Arrange
      string player1 = "Rock";
      Hand player1Hand = new Hand(player1, "Rock");

      //Act
      string result = player1Hand.GetPlayer1();

      //Assert
      Assert.Equal(true, Hand.PlayGame(result, "Rock"));
      // WL should return "Tie"
    }

    [Fact]
    public void PlayGame_TestForTie_true()
    {
      //Arrange
      string player1 = "Rock";
      Hand player1Hand = new Hand(player1, "Rock");

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(true, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // WL should return "Tie"
    }

    [Fact]
    public void PlayGame_TestForLoss_false()
    {
      //Arrange
      string player1 = "Scissors";
      Hand player1Hand = new Hand(player1, "Rock");

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(false, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // Wl should return "Player Two Wins!"
    }

    [Fact]
    public void PlayGame_TestForPlayer1Win_true()
    {
      //Arrange
      string player1 = "Paper";
      Hand player1Hand = new Hand(player1, "Rock");

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(true, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // WL should return "Player One Wins!"
    }

    [Fact]
    public void PlayGame_Player2Input_true()
    {
      //Arrange
      string player2 = "Scissors";
      Hand player1Hand = new Hand("Scissors", player2);

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(true, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // WL should return "Tie"
    }

    [Fact]
    public void PlayGame_TestForPlayer2Win_false()
    {
      //Arrange
      string player2 = "Scissors";
      string player1 = "Paper";
      Hand player1Hand = new Hand(player1, player2);

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(false, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // WL should return "Player Two Wins!"
    }
  }
}
