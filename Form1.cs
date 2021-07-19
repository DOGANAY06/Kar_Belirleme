using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun,barkod;
            int gelis,  satis;
            double kdv;
            double kazanc;
            urun = textBox1.Text; //ürün adı
            barkod = maskedTextBox1.Text; //11 haneli barkod numarası aldım maskeleyerek
            gelis = Convert.ToInt32(textBox2.Text); //geliş fiyatı
            kdv = Convert.ToDouble(textBox3.Text); //kdv tutarı
            satis = Convert.ToInt32(textBox4.Text); //satış fiyatı 
            kazanc = satis - (gelis + (gelis * kdv)); //kazancımız
            listBox1.Items.Add(barkod + " Barkod nolu " +urun +" kazancı " +kazanc);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
