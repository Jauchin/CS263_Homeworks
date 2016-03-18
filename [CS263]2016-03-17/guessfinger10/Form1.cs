using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessfinger10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] tbs1 = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            TextBox[] tbs2 = { textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20 };
            Random rdn = new Random();
            int[] a = new int[10];
            int count1 = 0, count2 = 0, count3 = 0;
            for (int index = 0; index < 10; index++)
            {
                a[index] = rdn.Next(1, 4);
                switch (a[index])
                {
                    case 1:
                        tbs1[index].Text = "剪刀";
                        count1++;
                        break;

                    case 2:
                        tbs1[index].Text = "石頭";
                        count2++;
                        break;

                    case 3:
                        tbs1[index].Text = "布";
                        count3++;
                        break;
                }
            }
            if (count1 == 0 && count2 * count3 != 0)
            {
                for (int index = 0; index < 10; index++)
                {
                    if (a[index] == 2)
                    {
                        tbs2[index].Text = "輸";
                    }
                    else
                    {
                        tbs2[index].Text = "贏";
                    }
                }
            }
            else if (count2 == 0 && count1 * count3 != 0)
            {
                for (int index = 0; index < 10; index++)
                {
                    if (a[index] == 3)
                    {
                        tbs2[index].Text = "輸";
                    }
                    else
                    {
                        tbs2[index].Text = "贏";
                    }
                }
            }
            else if (count3 == 0 && count1 * count2 != 0)
            {
                for (int index = 0; index < 10; index++)
                {
                    if (a[index] == 1)
                    {
                        tbs2[index].Text = "輸";
                    }
                    else
                    {
                        tbs2[index].Text = "贏";
                    }
                }
            }
            else
            {
                for (int index = 0; index < 10; index++)
                {
                    tbs2[index].Text = "平手";
                }
            }
        }
    }
}