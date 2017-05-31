using Nancy;
using HandProject.Objects;
using System.Collections.Generic;

namespace HandProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      }; //homepage

      Post["/"] = _ => {
        Hand player1 = new Hand(Request.Form["player-one"], Request.Form["player-two"]);
        string playerOneInput = player1.GetPlayer1();
        string playerTwoInput = player1.GetPlayer2();
        string output = Hand.PlayGame(playerOneInput, playerTwoInput);
        return View["index.cshtml", output];
      }; //homepage, display: win/loss/tie

      Get["/computer"] = _ => {
        Hand player1 = new Hand("", "");
        return View["computer.cshtml", player1];
      }; //play against computer

      Post["/computer"] = _ => {
        Hand player1 = new Hand(Request.Form["player-one"], "");
        string playerOneInput = player1.GetPlayer1();
        player1.VsAI(playerOneInput);
        return View["computer.cshtml", player1];
      };
    }
  }
}
