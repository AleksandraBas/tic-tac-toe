using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public static class Moves
    {
        public static void MovePlayers(BoardTTT board, NumberOfWinnings winnings)
        {
            do
            {
                int choNum;

                do
                {
                    string cn = Console.ReadLine();
                    choNum = Convert.ToInt32(cn);

                    if (board.listaB[choNum - 1] == "X" || board.listaB[choNum - 1] == "O")
                    {
                        Console.WriteLine("This place is filled. Player 1, please to choose another.");
                        continue;
                    }
                }
                while (board.listaB[choNum - 1] == "X" || board.listaB[choNum - 1] == "O");


                board.listaB[choNum - 1] = "X";

                board.Board();


                if ((board.listaB[0] == "X" && board.listaB[1] == "X" && board.listaB[2] == "X") ||
                    (board.listaB[3] == "X" && board.listaB[4] == "X" && board.listaB[5] == "X") ||
                    (board.listaB[6] == "X" && board.listaB[7] == "X" && board.listaB[8] == "X") ||
                    (board.listaB[0] == "X" && board.listaB[3] == "X" && board.listaB[6] == "X") ||
                    (board.listaB[1] == "X" && board.listaB[4] == "X" && board.listaB[7] == "X") ||
                    (board.listaB[2] == "X" && board.listaB[5] == "X" && board.listaB[8] == "X") ||
                    (board.listaB[0] == "X" && board.listaB[4] == "X" && board.listaB[8] == "X") ||
                    (board.listaB[2] == "X" && board.listaB[4] == "X" && board.listaB[6] == "X"))

                {
                    Console.WriteLine("Player 1 won !");
                    winnings.winningPlayer1List.Add(1);
                    winnings.numberGamesList.Add(1);
                    break;
                }

                var isFull  =  true;
                foreach (string pole in board.listaB)
                {
                    if (pole != "X" && pole != "O")
                    {
                        isFull = false;
                        break;
                    }
                }

                if (isFull)
                {
                    Console.WriteLine("Noone won.");
                    winnings.nooneWinningList.Add(1);
                    winnings.numberGamesList.Add(1);
                    break;
                }

                int choNum2;

                do
                {
                    string cn2 = Console.ReadLine();
                    choNum2 = Convert.ToInt32(cn2);

                    if (board.listaB[choNum2 - 1] == "X" || board.listaB[choNum2 - 1] == "O")
                    {
                        Console.WriteLine("This place is filled. Player 2, please to choose another.");
                        continue;
                    }
                }
                while (board.listaB[choNum2 - 1] == "X" || board.listaB[choNum2 - 1] == "O");


                board.listaB[choNum2 - 1] = "O";
                board.Board();

                if ((board.listaB[0] == "O" && board.listaB[1] == "O" && board.listaB[2] == "O") ||
                    (board.listaB[3] == "O" && board.listaB[4] == "O" && board.listaB[5] == "O") ||
                    (board.listaB[6] == "O" && board.listaB[7] == "O" && board.listaB[8] == "O") ||
                    (board.listaB[0] == "O" && board.listaB[3] == "O" && board.listaB[6] == "O") ||
                    (board.listaB[1] == "O" && board.listaB[4] == "O" && board.listaB[7] == "O") ||
                    (board.listaB[2] == "O" && board.listaB[5] == "O" && board.listaB[8] == "O") ||
                    (board.listaB[0] == "O" && board.listaB[4] == "O" && board.listaB[8] == "O") ||
                    (board.listaB[2] == "O" && board.listaB[4] == "O" && board.listaB[6] == "O"))

                {
                    Console.WriteLine("Player 2 won !");
                    winnings.winningPlayer2List.Add(1);
                    winnings.nooneWinningList.Add(1);
                    break;
                }
            }
            while (true);

        }

    }

}
