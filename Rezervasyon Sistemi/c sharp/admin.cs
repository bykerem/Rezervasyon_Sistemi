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
            guncelle guncelle = new guncelle();
            guncelle.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("otel ismi", 200);
            listView1.Columns.Add("fiyatı", 100);
            listView1.Columns.Add("boş yer sayisi", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            WebClient client = new WebClient();

            String isim = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/listele_isim/");

            // String[] array = new String[100];
            List<string> isim_liste = isim.Split(new char[] { '"' }).ToList();
            // List<string> isim_listele = isim_liste.Split(',').ToList();
            string[] isim_listesi = isim_liste.ToArray();




            string fiyat = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/listele_fiyat/");
            List<string> fiyat_liste = fiyat.Split(new char[] { '"' }).ToList();


            string bos = client.DownloadString("http://localhost:8080/5/webresources/cehars.rezervasyon/listele_bos/");
            List<string> bos_liste = bos.Split(new char[] { '"' }).ToList();

            int sayi = Int32.Parse(isim_listesi.Length.ToString());



            int sayac = 0;

            sayi = Int32.Parse(isim_listesi.Length.ToString());

            while (sayac < sayi)
            {

                ListViewItem ekle = new ListViewItem();

                // ekle.Text = isim_listesi.Length.ToString(); 

                if ((isim_liste[sayac]).Length != 1)
                {

                    ekle.Text = (isim_liste)[sayac];
                    ekle.SubItems.Add((fiyat_liste)[sayac]);
                    ekle.SubItems.Add((bos_liste)[sayac]);


                    listView1.Items.Add(ekle);
                }
                sayac = sayac + 1;

            }
        }
    }
}
