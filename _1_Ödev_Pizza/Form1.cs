using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PİZZA_SİPARİSLERİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double i = 0;
            if (pmantar.Checked)
            {
                i = i + 14;
            }
            if (pvenedik.Checked)
            {
                i = i + 7;
            }
            if (psebze.Checked)
            {
                i = i + 9;
            }
            if (psucuk.Checked)
            {
                i = i + 16;
            }
            
            if ( ckbCola.Checked)
            {
                i = i + 4;
            }
            if (ckbFanta.Checked)
            {
                i = i + 2.5;
            }
            
            if (ckbAyran.Checked)
            {
                i = i + 3;
            }
            if (ckbSu.Checked)
            {
                i = i + 1;
            }
            textTutar.Text = i.ToString();
        }

        private void btnYeniSİparis_Click(object sender, EventArgs e)
        {
            {
                textTutar.Text = "00";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
