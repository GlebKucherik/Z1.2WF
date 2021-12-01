using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1._2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a = 0;
        public int b = 0;
        public string chislo = "";
        public char[] bukva;
        void Main()
        {
            if (Int32.TryParse(textBox1.Text, out a) && textBox1.Text.Length == 3)
            {
                chislo = textBox1.Text;
                bukva = chislo.ToCharArray();
                a = Int32.Parse(bukva[0].ToString());
                b = Int32.Parse(bukva[1].ToString());
                if (a > b)
                {
                    label2.Text = "Первая цифра больше второй";
                }
                else if (a < b)
                {
                    label2.Text = "Вторая цифра больше первой";
                }
                else if (a == b)
                {
                    label2.Text = "Первая цифра равна второй";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не трёхзначное число");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
