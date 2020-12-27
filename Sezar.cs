using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme
{
    public partial class Sezar : Form
    {
        public Sezar()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri = textBox1.Text;
            char[] karakter = veri.ToCharArray();
            foreach(char x in karakter)
            {
                textBox2.Text += Convert.ToChar(x+2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sifre = "";
            sifre = textBox2.Text;
            char[] karakter2 = sifre.ToCharArray();
            foreach(char x2 in karakter2)
            {
                textBox1.Text += Convert.ToChar(x2 - 2).ToString();
            }
        }
    }
}
