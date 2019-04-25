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
  }
}
