using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class QualifyList
    {
        public int fourDigit;
        public int[] QList;

        public void getNoRepeat4Digit(int[] list)
        {
            int i;
            int D1, D2, D3, D4;
            for (i = 0; i < 10000; i++)
            {
                D1 = i / 1000;
                D2 = (i - 1000 * D1) / 100;
                D3 = (i - 1000 * D1 - 100 * D2) / 10;
                D4 = i % 10;
                if (!(D1 == D2 || D1 == D3 || D1 == D4 || D2 == D3 || D2 == D4 || D3 == D4))
                    list[i] = i;
            }
        }

        public int chooseFromAry(int[] ary)
        {
            Random rdn = new Random();
            int choice;
            choice = rdn.Next(0, ary.Length);
            fourDigit = ary[choice];
            return fourDigit;
        }
    }
}