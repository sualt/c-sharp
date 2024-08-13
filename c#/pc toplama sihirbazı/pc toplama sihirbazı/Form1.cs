using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_toplama_sihirbazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float fiyat;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="DELL")
            {
                fiyat += 150;
            }
            else if(comboBox1.Text=="CASPER")
            {
                fiyat += 180;
            }
            else if(comboBox1.Text=="HP")
            {
                fiyat += 200;
            }
            else if(comboBox1.Text=="LENOVO")
            {
                fiyat += 175;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="i7")
            {
                fiyat += 25;
            }
            else if(comboBox2.Text=="i9")
            {
                fiyat += 35;
            }
            else if(comboBox2.Text=="ryzen")
            {
                fiyat += 40;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.Text=="8 gb ram")
            {
                fiyat += 45;
            }
            else if(comboBox3.Text=="16 gb ram")
            {
                fiyat += 75;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.Text=="rtx 3060 ti")
            {
                fiyat += 25;
            }
            else if(comboBox4.Text=="rtx 3070")
            {
                fiyat += 45;
            }
            else if(comboBox4.Text=="rtx 3090")
            {
                fiyat += 75;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = fiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiyat = 0;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            label6.Text = null;
            label7.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = ("Marka:" + comboBox1.Text.ToString() + "İşlemci:" + comboBox2.Text.ToString() + "Ram" + 
                comboBox3.Text.ToString() + "Ekran Kartı:" + comboBox4.Text.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
