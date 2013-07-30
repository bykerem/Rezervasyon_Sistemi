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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sil sil = new Sil();
            sil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fiyat_sorgula fiyat_sorgula = new fiyat_sorgula();
            fiyat_sorgula.Show();
        }
    }
}
