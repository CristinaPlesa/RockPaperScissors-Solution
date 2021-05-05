using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Play
  {
    // properties, constructors, methods, etc. go here
    // public string GetResult { get; }
    public string PlayerOneInput { get; }
    
    public string PlayerTwoInput { get; }

    public Play(string playerOneInput, string playerTwoInput)
    {
      PlayerOneInput = playerOneInput;
      PlayerTwoInput = playerTwoInput;
    }

    public static string ExecutePlay(Play currentPlay)
    {
      if (currentPlay.PlayerOneInput == currentPlay.PlayerTwoInput)
      {
        return "draw";
      }
      else if ((currentPlay.PlayerOneInput == "rock" && currentPlay.PlayerTwoInput == "scissors")
        || (currentPlay.PlayerOneInput == "paper" && currentPlay.PlayerTwoInput == "rock")
        || (currentPlay.PlayerOneInput == "scissors" && currentPlay.PlayerTwoInput == "paper"))
      {
        return "Player One wins with " + currentPlay.PlayerOneInput + "!";
      }
      else if ((currentPlay.PlayerTwoInput == "paper" && currentPlay.PlayerOneInput == "rock")
      || (currentPlay.PlayerTwoInput == "rock" && currentPlay.PlayerOneInput == "scissors")
      || (currentPlay.PlayerTwoInput == "scissors" && currentPlay.PlayerOneInput == "paper"))
      {
        return "Player Two wins with " + currentPlay.PlayerTwoInput + "!";
      }
      else return "Please enter paper, rock, or scissors.";
    }


  }
}

  //  public Item(string description)
  //   {
  //     Description = description;
  //     _instances.Add(this);
  //   }