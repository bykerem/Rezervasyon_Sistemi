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
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {

                admin admin = new admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.Show();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
