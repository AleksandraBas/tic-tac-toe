using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class NumberOfWinnings
    {
        public List<int> winningPlayer1List;
        public List<int> winningPlayer2List;
        public List<int> nooneWinningList;
        public List<int> numberGamesList;

        public NumberOfWinnings()
        {
            this.winningPlayer1List = new List<int>();
            this.winningPlayer2List = new List<int>();
            this.nooneWinningList = new List<int>();
            this.numberGamesList = new List<int>();
        }
        public void ShowNumberofWinnings()
        {
            int nooneWon = nooneWinningList.Count();
            Console.WriteLine("Noone won " + nooneWon + " times.");
            int player1Won = winningPlayer1List.Count();
            Console.WriteLine("Player 1 won: " + player1Won + " times.");
            int player2Won = winningPlayer2List.Count();
            Console.WriteLine("Player 2 won: " + player2Won + " times.");
            int numberOfPlays = numberGamesList.Count();
            Console.WriteLine("Number of games: " + numberOfPlays);

        }
    }
}
