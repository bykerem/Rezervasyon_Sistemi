﻿using System;
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
    public partial class fiyat_sorgula : Form
    {
        public fiyat_sorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz !!!");
                }
                else
                {
                    WebClient client = new WebClient();
                    string text = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/fiyat/" + textBox1.Text);
                    MessageBox.Show(text);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sorgulama Sırasında Hata Oluştu !!!");
            }
        }

        private void fiyat_sorgula_Load(object sender, EventArgs e)
        {

        }
    }
}
