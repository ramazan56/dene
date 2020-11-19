using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[6];
            Random rdm = new Random();
            int tt=0;
            label1.Text = textBox1.Text+" :";
            for (int i = 0; i < 6; i++)
            {
                tt = rdm.Next(1, 90);
                dizi[i] = tt;

                label1.Text += "-"+dizi[i].ToString();
            }

        }
    }
}
