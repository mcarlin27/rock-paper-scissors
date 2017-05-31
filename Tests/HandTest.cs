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
    }
  }
}
