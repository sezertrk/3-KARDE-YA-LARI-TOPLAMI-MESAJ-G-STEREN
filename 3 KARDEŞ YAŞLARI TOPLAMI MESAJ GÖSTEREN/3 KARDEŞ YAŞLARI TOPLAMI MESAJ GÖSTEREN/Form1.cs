using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_KARDEŞ_YAŞLARI_TOPLAMI_MESAJ_GÖSTEREN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1 = int.Parse (textBox1.Text);
            int k2 = int .Parse (textBox2.Text);
            int k3 = int .Parse (textBox3.Text);
            int son;
            son = k1 + k2 + k3;
            MessageBox.Show  (son.ToString());
                
        }
    }
}
