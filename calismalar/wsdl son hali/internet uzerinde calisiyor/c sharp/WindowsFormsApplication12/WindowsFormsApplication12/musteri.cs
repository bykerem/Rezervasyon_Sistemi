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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
        

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("otel ismi", 150);
            listView1.Columns.Add("fiyatı", 100);
            listView1.Columns.Add("bos", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fiyat_sorgula fiyat_sorgula = new fiyat_sorgula();
            fiyat_sorgula.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bosyer_sorgula bosyer_sorgula = new bosyer_sorgula();
            bosyer_sorgula.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buton1 yer_ayirt = new buton1();
            yer_ayirt.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
