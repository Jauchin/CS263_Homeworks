using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessfinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int condition = int.Parse(textBox1.Text);
                switch (condition)
                {
                    case 1:
                        textBox1.Text = "剪刀";
                        break;

                    case 2:
                        textBox1.Text = "石頭";
                        break;

                    case 3:
                        textBox1.Text = "布";
                        break;
                }

                Random rdn = new Random();
                int a = rdn.Next(1, 4);

                switch (a)
                {
                    case 1:
                        textBox2.Text = "剪刀";
                        break;

                    case 2:
                        textBox2.Text = "石頭";
                        break;

                    case 3:
                        textBox2.Text = "布";
                        break;
                }
                if (condition == a)
                {
                    textBox3.Text = "平手";
                    textBox6.Text = (int.Parse(textBox6.Text) + 1).ToString();
                }
                else if (condition - a == 1 || condition - a == -2)
                {
                    textBox3.Text = "贏";
                    textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
                }
                else if (condition - a == 2 || condition - a == -1)
                {
                    textBox3.Text = "輸";
                    textBox5.Text = (int.Parse(textBox5.Text) + 1).ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}