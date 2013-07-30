using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;

namespace web_servis_istemcisi
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string text = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/ekle/" + textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text);
            MessageBox.Show(text);
            this.Close();  
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ekle_Load(object sender, EventArgs e)
        {

        }

       
    }
}
