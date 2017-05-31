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
      Hand player1Hand = new Hand(player1);

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
      Hand player1Hand = new Hand(player1);

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
      Hand player1Hand = new Hand(player1);

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(false, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // Wl should return "Player one loses"
    }

    [Fact]
    public void PlayGame_TestForWin_true()
    {
      //Arrange
      string player1 = "Paper";
      Hand player1Hand = new Hand(player1);

      //Act
      string resultPlayer1 = player1Hand.GetPlayer1();
      string resultPlayer2 = player1Hand.GetPlayer2();

      //Assert
      Assert.Equal(true, Hand.PlayGame(resultPlayer1, resultPlayer2));
      // WL shoild return "Player One Wins!"

    }
  }
}
