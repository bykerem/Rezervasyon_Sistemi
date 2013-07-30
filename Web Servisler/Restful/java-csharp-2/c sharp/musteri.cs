using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace web_servis_istemcisi
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fiyat_sorgula fiyat_sorgula = new fiyat_sorgula();
            fiyat_sorgula.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bosyer_sorgula bosyer_sorgula = new bosyer_sorgula();
            bosyer_sorgula.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listele guncelle = new listele();
            guncelle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yer_ayirt yer_ayirt = new yer_ayirt();
            yer_ayirt.Show();
        }
    }
}
