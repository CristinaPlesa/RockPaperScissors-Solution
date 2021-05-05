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
      Play newPlay = new Play();
      Assert.AreEqual(typeof(Play), newPlay.GetType());
    }

    // [TestMethod]
    // public void PlayRound_PlayARoundOfRPS_Draw()
    // {
    // // Arrange
    // string playerOneInput = "rock";
    // string playerTwoInput = "rock";
    // string result = "draw";

    // // Act
    // string output = Play.PlayRound(playerOneInput, playerTwoInput);

    // // Assert
    // Assert.AreEqual(result, output);
    // }
  }
}

  // [TestMethod]
  //   public void SetDescription_SetDescription_String()
  //   {
  //     //Arrange
  //     string description = "Walk the dog.";
  //     Item newItem = new Item(description);
  //     //Act
  //     string updatedDescription = "Do the dishes";
  //     newItem.Description = updatedDescription;
  //     string result = newItem.Description;
  //     //Assert
  //     Assert.AreEqual(updatedDescription, result);
  //   }


// Test template
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }