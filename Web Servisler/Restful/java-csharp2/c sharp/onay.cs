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
    public partial class onay : Form
    {
        public onay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string text = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/onay/" + label3.Text + "/" + label4.Text);
            MessageBox.Show(text);
            this.Close();  
        }
    }
}
