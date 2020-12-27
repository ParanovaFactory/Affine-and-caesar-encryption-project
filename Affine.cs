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
    public partial class Affine : Form
    {
        public Affine()
        {
            InitializeComponent();
        }
        string[] affine_alfabe = new string[] 
{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = MetinTxt.Text;
                int a = int.Parse(akey.Text);
                int b = int.Parse(bkey.Text);
                int x = 0;
                int Ey = 0;
                string smetin = "";
                metin = metin.ToUpper(); 

                for (int i = 0; i < metin.Length; i++) 
                {
                    string pmetin = metin.Substring(i, 1); 

                    if (pmetin == "Ç") pmetin = "C"; if (pmetin == "Ğ") pmetin = "G"; if (pmetin == "İ") pmetin = "I";
                    if (pmetin == "Ö") pmetin = "O"; if (pmetin == "Ş") pmetin = "S"; if (pmetin == "Ü") pmetin = "U";

                    for (int j = 0; j < affine_alfabe.Length; j++) 
                    {
                        if (pmetin == affine_alfabe[j]) 
                        { break; }
                        else 
                        { x++; }
                    }
                    if (pmetin == " ") 
                    {
                        smetin += " "; 
                        x = 0; 
                    }
                    else if (char.Parse(pmetin) >= 48 && char.Parse(pmetin) <= 57) 
                    {
                        smetin += pmetin; 
                        x = 0; 
                    }
                    else 
                    {
                        Ey = (a * x + b) % 26; 
                        x = 0; 
                        smetin += affine_alfabe[Ey]; 
                    }
                }
                encTxt.Text = smetin; 
            }
            catch (Exception) 
            {
                MessageBox.Show("Hatalı Veri Girişi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = MetinTxt.Text;
                int a = int.Parse(akey.Text);
                int b = int.Parse(bkey.Text);
                int x = 0, mters = 0;
                int Dy = 0;
                string cmetin = "";
                metin = metin.ToUpper(); 

                for (int i = 0; i < metin.Length; i++) 
                {
                    string pmetin = metin.Substring(i, 1); 

                    for (int j = 0; j < affine_alfabe.Length; j++) 
                    {
                        if (pmetin == affine_alfabe[j]) 
                        { break; }
                        else 
                        { x++; }
                    }
                    if (pmetin == " ") 
                    {
                        cmetin += " "; 
                        x = 0;
                    }
                    else if (char.Parse(pmetin) >= 48 && char.Parse(pmetin) <= 57) 
                    {
                        cmetin += pmetin; 
                        x = 0; 
                    }
                    else 
                    {
                        for (int modters = 1; modters < 27; modters++) 
                        {
                            if ((a * modters) % 26 == 1) 
                            {
                                mters = modters;
                                break;
                            }
                        }
                        if (mters != 0) 
                        {
                            if (x - b < 0) x += 26; 
                            Dy = (mters * (x - b)) % 26; 
                            x = 0; 
                            cmetin += affine_alfabe[Dy]; 
                        }
                        else if (mters == 0)
                        {
                            MessageBox.Show("a anahtarının modüler tersi olmadığı için çözme işlemi gerçekleştirilemiyor!\nBu yüzden a anahtarı tek sayı olmalıdır.", "Modüler Ters");
                            break;
                        }
                    }
                }
                decTxt.Text = cmetin; 
            }
            catch (Exception) 
            {
                MessageBox.Show("Hatalı Veri Girişi");
            }
        }

        private void Affine_Load(object sender, EventArgs e)
        {

        }
    }
    }

  