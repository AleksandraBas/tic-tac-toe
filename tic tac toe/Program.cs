using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)

        { 

            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("Player1 - X, Player2 - O");
            Console.WriteLine("How many games do you want to have?");
            int numGames;
            string nG = Console.ReadLine();
            numGames = Convert.ToInt32(nG);
            
            NumberOfWinnings ourWinnings = new NumberOfWinnings();

            do
            {
                Console.WriteLine("Player1, please to choose number on the board");
                BoardTTT ourBoard = new BoardTTT();
                ourBoard.Board();

                Moves.MovePlayers(ourBoard, ourWinnings);
                ourWinnings.ShowNumberofWinnings();
            }
            while (ourWinnings.numberGamesList.Count < numGames);
        }


        
    }
}

