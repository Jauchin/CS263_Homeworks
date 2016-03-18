using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerGuessGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Finger = 0,
                Status = 0
            };

            Player player2 = new Player
            {
                Finger = 0,
                Status = 0
            };

            player1.Finger = player1.getFinger();
            player2.Finger = player2.getFinger();
            player1.judgeStatus(player1.Finger, player2.Finger);
            Console.WriteLine(player1.Finger);
            Console.WriteLine(player2.Finger);
            Console.WriteLine(player1.Status);
        }
    }
}