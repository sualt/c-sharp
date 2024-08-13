using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiyat_bilgisi
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
            if (comboBox1.Text == "Intel Core i7 İşlemci")
            {
                fiyat = 35;
            }
            else if (comboBox1.Text == "AMD Ekran Kartı RX580")
            {
                fiyat = 78;
            }
            else if (comboBox1.Text == "8 gb DDR4 Ram")
            {
                fiyat = 30;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = fiyat.ToString();
        }

        
    }
}
