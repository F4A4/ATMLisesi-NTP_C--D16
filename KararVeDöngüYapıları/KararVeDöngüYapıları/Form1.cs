using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KararVeDöngüYapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int OrtalamaBul = Int32.Parse(textBox1.Text);
            if (OrtalamaBul<=45)
            {
                MessageBox.Show("KALDIN");  
            }
            else 
            {
                MessageBox.Show("GEÇTİN"); 
            }
        }

        public bool NoktaVarMı(string metin)
        {
            
            if (metin.EndsWith("."))
            {
                return true; 
            }
            else
            {
                return false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool sonuc = NoktaVarMı(textBox2.Text);
            if (sonuc)
            {
                label1.Text = "metinin sonunda nokta var"; 
            }
            else
            {
                label1.Text = "metinin sonunda nokta yok";
            }
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
          int soru = Int32.Parse(textBox3.Text);
          int vergi;
            if (soru>150)
            {
                vergi = soru * 15 / 100;
               
            }
            else
            {
                vergi = soru * 18 / 100;
               
            }
            label2.Text = (soru + vergi).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kilo = Int32.Parse(textBox5.Text);
            int boy = Int32.Parse(textBox6.Text);
            int sonuc = (boy * boy) / kilo;
            
            if (sonuc<19)
            {
                label3.Text = "ÇOK ZAYIFSIN";
               
            }
            else if (sonuc>=25)
            {
                label3.Text = "ÇOK ŞİŞMANSIN";
                
            }
            else
            {
                label3.Text = "NORMALSİN";
                
            }
            
         }
        public float vkiBul(float boy,byte kilo)
        {
            float sonuc = (boy * boy) / kilo;
            return sonuc;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            float b1 = Convert.ToSingle(textBox6.Text);
            byte k1 = Convert.ToByte(textBox7.Text);
            float sonucc = vkiBul(b1,k1);
            MessageBox.Show(sonucc.ToString());
            if (sonucc>=25)
            {
                label8.Text = "ÇOK ŞİŞMANSIN";
            }
            else if (sonucc<19)
            {
                label8.Text = "ÇOK ZAYIFSIN";
            }
            else
            {
                label8.Text = "NORMALSİN";
            }
            
        }
                    
            
        }
       
    }

