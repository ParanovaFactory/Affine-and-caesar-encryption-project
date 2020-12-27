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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sezar sz = new Sezar();
            sz.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Affine af = new Affine();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Verman vr = new Verman();
            vr.Show();
        }
    }
}
