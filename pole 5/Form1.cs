using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_5
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
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int[] puvodni = new int[n];
            Random rn = new Random();

            int cislo;
            for (int i = 0; i < n; i++)
            {
                cislo = rn.Next(1, 100);
                puvodni[i] = cislo;
            }

            foreach (int k in puvodni)
            {
                listBox1.Items.Add(k.ToString());
            }

            Array.Sort(puvodni);
            foreach (int k in puvodni)
            {
                listBox4.Items.Add(k.ToString());
            }
            
            int index = 0;

            for (int j = 0; j < n; j++)
            {
                if (puvodni[j] <= b)
                    index = j;
                else
                    break;
            }

            if (index > 0)
            {
                int[] mensi = puvodni.Take(index).ToArray();


                foreach (int k in mensi)
                {
                    listBox2.Items.Add(k.ToString());
                }

            }

            int[] vetsi = puvodni.Skip(index + 1).ToArray();
            foreach (int k in vetsi)
            {
                listBox3.Items.Add(k.ToString());
            }
        }
    }
}