using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Game;

namespace GameTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestTieCondition_InputRockRock_ReturnTie()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Assert.AreEqual(Listof_Results.tie, rps.Play(Listof_Choices.rock, Listof_Choices.rock));
    }
    [TestMethod]
    public void TestWinCondition_InputRockPaper_ReturnPlayer2()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Assert.AreEqual(Listof_Results.player2, rps.Play(Listof_Choices.rock, Listof_Choices.paper));
    }

    [TestMethod]
    public void TestWinCondition_InputRockScissors_ReturnPlayer1()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Assert.AreEqual(Listof_Results.player2, rps.Play(Listof_Choices.scissors, Listof_Choices.rock));
    }

    [TestMethod]
    public void TestWinCondition_Inputpaperscissors_ReturnPlayer2()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Assert.AreEqual(Listof_Results.player1, rps.Play(Listof_Choices.scissors, Listof_Choices.paper));
    }

    [TestMethod]
    public void TestWinCondition_IncorrectInput()
    {
      RockPaperScissors rps = new RockPaperScissors();
      Assert.AreEqual(Listof_Results.badChoices, rps.Play((Listof_Choices)(-34), (Listof_Choices)56));
    }

  }
}
