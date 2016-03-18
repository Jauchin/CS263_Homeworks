using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player
    {
        public int Finger;     //finger1=剪刀, 2=石頭, 3=布
        public int Status;     //status1= player1 win, 2=平手, 3=lose

        private Random rnd = new Random();

        public int getFinger()
        {
            this.Finger = rnd.Next(1, 4);
            return this.Finger;
        }

        public int judgeStatus(int fingerA, int fingerB)
        {
            if (fingerA - fingerB == 0)
            {
                return this.Status = 2;  //平手
            }
            else if (fingerA - fingerB == 1 || fingerA - fingerB == -2)
            {
                return this.Status = 1;  //player1 win
            }
            else if (fingerA - fingerB == 2 || fingerA - fingerB == -1)
            {
                return this.Status = 3;  //player1 lose
            }
            else
            {
                return this.Status = 0;
            }
        }
    }
}