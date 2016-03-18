using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Answer;
        public int i, j, guessTimes = 0;
        public int D1, D2, D3, D4;
        public int tmp1, tmp2, tmp3, tmp4;
        public Random rdn = new Random();
        private int[] list = new int[10000];

        public int checkA(int number1, int number2)
        {
            int countA = 0;
            D1 = number1 / 1000;
            D2 = (number1 - 1000 * D1) / 100;
            D3 = (number1 - 1000 * D1 - 100 * D2) / 10;
            D4 = number1 % 10;
            tmp1 = number2 / 1000;
            tmp2 = (number2 - 1000 * tmp1) / 100;
            tmp3 = (number2 - 1000 * tmp1 - 100 * tmp2) / 10;
            tmp4 = number2 % 10;
            if (D1 == tmp1)
                countA++;
            if (D2 == tmp2)
                countA++;
            if (D3 == tmp3)
                countA++;
            if (D4 == tmp4)
                countA++;
            return countA;
        }

        public int checkB(int number1, int number2)
        {
            int countB = 0;
            D1 = number1 / 1000;
            D2 = (number1 - 1000 * D1) / 100;
            D3 = (number1 - 1000 * D1 - 100 * D2) / 10;
            D4 = number1 % 10;
            tmp1 = number2 / 1000;
            tmp2 = (number2 - 1000 * tmp1) / 100;
            tmp3 = (number2 - 1000 * tmp1 - 100 * tmp2) / 10;
            tmp4 = number2 % 10;
            if (D1 == tmp2)
                countB++;
            if (D1 == tmp3)
                countB++;
            if (D1 == tmp4)
                countB++;
            if (D2 == tmp1)
                countB++;
            if (D2 == tmp3)
                countB++;
            if (D2 == tmp4)
                countB++;
            if (D3 == tmp1)
                countB++;
            if (D3 == tmp2)
                countB++;
            if (D3 == tmp4)
                countB++;
            if (D4 == tmp1)
                countB++;
            if (D4 == tmp2)
                countB++;
            if (D4 == tmp3)
                countB++;
            return countB;
        }

        public int deleteList(int[] ary, int j, int number, int A, int B)
        {
            int k = 0;
            for (i = 0; i < j; i++)
            {
                if ((checkA(ary[i], number) == A) && (checkB(ary[i], number) == B))
                {
                    ary[k] = ary[i];
                    k++;
                }
            }
            return k;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            j = 0;

            for (i = 0; i < 10000; i++)
            {
                D1 = i / 1000;
                D2 = (i - 1000 * D1) / 100;
                D3 = (i - 1000 * D1 - 100 * D2) / 10;
                D4 = i % 10;
                if (!(D1 == D2 || D1 == D3 || D1 == D4 || D2 == D3 || D2 == D4 || D3 == D4))
                {
                    list[j] = i;
                    j++;
                }
            }
            Answer = list[rdn.Next(0, j)];
            label1.Text = Answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guess;
            guess = list[rdn.Next(0, j)];
            guessTimes++;
            label2.Text = guess.ToString();
            label3.Text = checkA(Answer, guess).ToString() + "A" +
                          checkB(Answer, guess).ToString() + "B";
            if (Answer == guess)
            {
                label5.Text = "恭喜, 猜中了";
            }
            j = deleteList(list, j, guess, checkA(Answer, guess), checkB(Answer, guess));

            label4.Text = "這是第" + guessTimes + "次猜, 猜完剩下" + j + "種可能";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            j = 0;
            guessTimes = 0;
        }
    }
}