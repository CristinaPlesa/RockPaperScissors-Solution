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
    Assert.AreEqual(playerOneInput, newPlay.PlayerOneInput);
    Assert.AreEqual(playerTwoInput, newPlay.PlayerTwoInput);
    }

    [TestMethod]
    public void PlayRound_PlayARoundOfRPS_Draw()
    {
    // Arrange
    Play newPlay = new Play("rock", "rock");

    // Act
    string result = "draw";
    string output = newPlay.ExecutePlay();

    // Assert
    Assert.AreEqual(result, output);
    }
  }
}


    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.Description = updatedDescription;
    //   string result = newItem.Description;
    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }


// Test template
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }