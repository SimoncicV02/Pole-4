using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_6
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

            int n = Convert.ToInt32(textBox1.Text);

            int[] pole = new int[n];
            Random rn = new Random();

            int cislo;
            for(int i = 0; i < n; i++)
            {
                cislo = rn.Next(1, 100);
                pole[i] = cislo;
            }

            double prumer = pole.Average();
            label1.Text = "Průměr prvků: " + prumer;
            int max = int.MinValue;

            foreach (int k in pole)
            {
                listBox1.Items.Add(k);
                if (k <= prumer && k > max)
                    max = k;
            }
            label2.Text = "Max <= průměru " + max;
        }
    }
}
