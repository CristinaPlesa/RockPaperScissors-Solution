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
        return "win";
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