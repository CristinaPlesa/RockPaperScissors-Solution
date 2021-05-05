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
    public void ExecutePlay_PlayARoundOfRPSWithRocks_Draw()
    {
    // Arrange
    Play newPlay = new Play("rock", "rock");

    // Act
    string result = "draw";
    string output = Play.ExecutePlay(newPlay);

    // Assert
    Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayARoundOfRPSWithPaper_Draw()
    {
    // Arrange
    Play newPlay = new Play("paper", "paper");

    // Act
    string result = "draw";
    string output = Play.ExecutePlay(newPlay);

    // Assert
    Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayARoundOfRPSWithScissors_Draw()
    {
    // Arrange
    Play newPlay = new Play("scissors", "scissors");

    // Act
    string result = "draw";
    string output = Play.ExecutePlay(newPlay);

    // Assert
    Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayerOneWinsWithRock_RockWins()
    {
      //Arrange
      Play newPlay = new Play("rock", "scissors");

      //Act
      string result = "Player One wins with rock!";
      string output = Play.ExecutePlay(newPlay);

      //Assert
      Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayerOneWinsWithPaper_PaperWins()
    {
      // Arrange
      Play newPlay = new Play("paper", "rock");

      // Act
      string result = "Player One wins with paper!";
      string output = Play.ExecutePlay(newPlay);

      // Assert
      Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayerOneWinsWithScissors_ScissorsWins()
    {
      // Arrange
      Play newPlay = new Play("scissors", "paper");

      // Act
      string result = "Player One wins with scissors!";
      string output = Play.ExecutePlay(newPlay);

      // Assert
      Assert.AreEqual(result, output);
    }

    [TestMethod]
    public void ExecutePlay_PlayerTwoWinsWithPaper_PaperWins()
    {
      // Arrange
      Play newPlay = new Play("rock", "paper");

      // Act
      string result = "Player Two wins with paper!";
      string output = Play.ExecutePlay(newPlay);

      // Assert
      Assert.AreEqual(result, output);
    }
  }
}

//* Player One wins when Player One throws rock and Player Two throws scissors

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