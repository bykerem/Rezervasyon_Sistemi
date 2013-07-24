using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// using System.Linq;
// using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            string text = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/ekle/" + textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text);
            MessageBox.Show(text);                    
    
        }
    }
}
