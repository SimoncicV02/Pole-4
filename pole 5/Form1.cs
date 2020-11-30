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

        
        int pozice = 1;
        int[] cislo;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            Random nh = new Random();
            int b = int.Parse(textBox2.Text);
            int n = Convert.ToInt32(textBox1.Text);
            cislo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int x = nh.Next(1, 100);
                cislo[i] = x;                
            }
            foreach (int y in cislo)
            {
                listBox4.Items.Add(y);
            }
            Array.Sort(cislo);
            foreach (int y in cislo)
            {
                listBox1.Items.Add(y);
            }
        }
         
        private void button2_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int[] mensi = cislo.Skip(pozice).ToArray();
            int[] vetsi = cislo.Take(pozice).ToArray();
            foreach(int y in mensi)
            {
                listBox2.Items.Add(y);
            }
            foreach(int y in vetsi)
            {
                listBox3.Items.Add(y);
            }
        }
    }
}
