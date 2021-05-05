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
      else if (currentPlay.PlayerOneInput == "rock" && currentPlay.PlayerTwoInput == "scissors")
      {
        return "Player One wins with rock!";
      }
      else if (currentPlay.PlayerOneInput == "paper" && currentPlay.PlayerTwoInput == "rock")
      {
        return "Player One wins with paper!";
      }
      else if (currentPlay.PlayerOneInput == "scissors" && currentPlay.PlayerTwoInput == "paper")
      {
        return "Player One wins with scissors!";
      }
      else if (currentPlay.PlayerTwoInput == "paper" && currentPlay.PlayerOneInput == "rock")
      {
        return "Player Two wins with paper!";
      }

      else return "not a draw";
    }


  }
}

  //  public Item(string description)
  //   {
  //     Description = description;
  //     _instances.Add(this);
  //   }