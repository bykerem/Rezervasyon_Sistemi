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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button5_Click(object sender, EventArgs e)
        {
            guncelle guncelle = new guncelle();
            guncelle.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listele guncelle = new listele();
            guncelle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String names = "Brian,Joe,Chris";
            List<string> result = names.Split(new char[] { ',' }).ToList();
            string[] myArray = result.ToArray();
            MessageBox.Show(myArray[0]);

            
        }

     
    }
}
