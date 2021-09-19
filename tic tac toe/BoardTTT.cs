using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class BoardTTT
    {

        public List<string> listaB;
        public BoardTTT()
        {
            this.listaB = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        }
        public void Board()
        {
            
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", listaB[0], listaB[1], listaB[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", listaB[3], listaB[4], listaB[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", listaB[6], listaB[7], listaB[8]);
            Console.WriteLine("     |     |      ");
        }
      
        
    }
}
