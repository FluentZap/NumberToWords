using System;
using System.Collections.Generic;

namespace Game
{

  public class Program
  {
    public static void Main()
    {
      RunGame newGame = new RunGame();
      newGame.UIGame();
    }
  }



  public class RunGame
  {

    public void UIGame()
    {

      bool endGame = false;
      RockPaperScissors myGame = new RockPaperScissors();
      while(endGame == false)
      {
        Console.WriteLine("Do you want to play 1 or 2 player? Enter 1 or 2");
        ConsoleKeyInfo choice = Console.ReadKey(true);
        if (choice.Key == ConsoleKey.D1)
        {
          Console.WriteLine("1 Player Game!");
        }

        if (choice.Key == ConsoleKey.D2)
        {
          Console.WriteLine("2 Player🧟‍♂️ Game!");
          Console.WriteLine("Player 1: Enter 0 for rock, 1 for paper or 2 for scissors");
          ConsoleKeyInfo player1 = Console.ReadKey(true);
          Listof_Choices player1Number = (Listof_Choices)Char.GetNumericValue(player1.KeyChar);
          Console.WriteLine("Player 2: Enter 0 for rock, 1 for paper or 2 for scissors");
          ConsoleKeyInfo player2 = Console.ReadKey(true);
          Listof_Choices player2Number = (Listof_Choices)Char.GetNumericValue(player2.KeyChar);
          Listof_Results result = myGame.Play(player1Number, player2Number);
          Console.WriteLine("{0} Wins! 🏄🏽‍♂️", result);

          Console.WriteLine("🏄🏽");
          break;
        }
        Console.WriteLine("Opps i said...");
      }
    }



  }




}
