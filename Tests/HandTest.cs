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
      Hand newHand = new Hand(player1);

      //Act
      string result = newHand.GetPlayer1();

      //Assert
      Assert.Equal(player1, result);
    }
  }
}
