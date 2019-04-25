using System;
namespace Game
{

  public enum Listof_Choices
  {
    rock,
    paper,
    scissors,
    random
  }
  public enum Listof_Results
  {
    tie,
    player1,
    player2,
    badChoices
  }

  public class RockPaperScissors
  {

    private Listof_Choices RandomChoice()
    {
      Random r = new Random();
      return (Listof_Choices)r.Next(0, 2);
    }


    public Listof_Results Play(Listof_Choices player1, Listof_Choices player2 = Listof_Choices.random)
    {
      if (player2 == Listof_Choices.random) player2 = RandomChoice();

      int choices = Enum.GetValues(typeof(Listof_Choices)).Length;
      if ((int)player1 >= 0 && (int)player1 < choices && (int)player2 >= 0 && (int)player2 < choices)
      {
        if(player1 == player2) { return Listof_Results.tie; }
        if(player1 == Listof_Choices.rock && player2 != Listof_Choices.paper) { return Listof_Results.player1; }
        if(player1 == Listof_Choices.paper && player2 != Listof_Choices.scissors) { return Listof_Results.player1; }
        if(player1 == Listof_Choices.scissors && player2 != Listof_Choices.rock) { return Listof_Results.player1; }
        return Listof_Results.player2;
      }
      else
      {
        return Listof_Results.badChoices;
      }
    }
  }
}
