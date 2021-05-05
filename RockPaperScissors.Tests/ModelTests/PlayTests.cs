using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class PlayTests
  {
    [TestMethod]
    public void PlayConstructor_CreatesInstanceOfPlay_Play()
    {
      Play newPlay = new Play("test", "test");
      Assert.AreEqual(typeof(Play), newPlay.GetType());
    }

    [TestMethod]
    public void PlayConstructor_ReturnOfPlay_Play()
    {
    //Arrange
    string playerOneInput = "rock";
    string playerTwoInput = "rock";
    
    // Act
    Play newPlay = new Play(playerOneInput, playerTwoInput);

    // Assert
    Assert.AreEqual(playerOneInput, newPlay.playerOneInput);
    Assert.AreEqual(playerTwoInput, newPlay.playerTwoInput);
    }

    // [TestMethod]
    // public void PlayRound_PlayARoundOfRPS_Draw()
    // {
    // // Arrange
    // string result = "draw";

    // // Act
    // string output = Play.PlayRound(playerOneInput, playerTwoInput);

    // // Assert
    // Assert.AreEqual(result, output);
    // }
  }
}


// Test template
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }