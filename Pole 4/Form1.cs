using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = int.Parse(textBox1.Text);
            Random nh = new Random();
            int[] cislo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int x = nh.Next(0, 10);
                cislo[i] = x;
            }
            foreach(int y in cislo)
            {
                listBox1.Items.Add(y);
            }
            cislo = cislo.Distinct().ToArray();
            foreach (int y in cislo)
            {
                listBox2.Items.Add(y);
            }
        }
    }
}
