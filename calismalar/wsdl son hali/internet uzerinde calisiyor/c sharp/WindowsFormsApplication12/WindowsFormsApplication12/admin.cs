using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

       

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            ekle ekle = new ekle();
            ekle.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sil sil = new sil();
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
            listView1.Columns.Add("otel ismi", 150);
            listView1.Columns.Add("fiyatı", 100);
            listView1.Columns.Add("bos", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            listView1.Items.Clear();



            int sayi = Int32.Parse((myService2.listele_isim()).Length.ToString());

            int sayac = 0;

            while (sayac < sayi)
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = (myService2.listele_isim())[sayac];
                ekle.SubItems.Add((myService2.listele_fiyat())[sayac]);
                ekle.SubItems.Add((myService2.listele_bos())[sayac]);
                sayac = sayac + 1;

                listView1.Items.Add(ekle);

            }
        }

        
            
       
        
    }
}
