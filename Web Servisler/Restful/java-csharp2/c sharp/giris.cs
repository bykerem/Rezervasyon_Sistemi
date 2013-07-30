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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.Show();
        }
    }
}
