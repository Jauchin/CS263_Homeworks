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

        private void button1_Click(object sender, EventArgs e)
        {
            QualifyList list = new QualifyList
            {
                fourDigit = 1234,
                QList = new int[10000]
            };

            list.getNoRepeat4Digit(list.QList);
            Console.WriteLine(list.QList[5000]);
        }
    }
}