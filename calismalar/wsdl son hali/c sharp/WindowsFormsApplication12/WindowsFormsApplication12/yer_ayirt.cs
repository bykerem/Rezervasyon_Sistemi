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
    public partial class buton1 : Form
    {
        public buton1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
            String rezerve_string = myService2.onay3(textBox1.Text, textBox2.Text).ToString();

            if (rezerve_string == "Otel Bulunamadı")
            {
                MessageBox.Show("Otel Bulunamadı");
            }
            else if (rezerve_string == "otel dolu")
            {
                MessageBox.Show("otel dolu");
            }
            else if (rezerve_string.Length > 20)
            {
                MessageBox.Show(rezerve_string);
            }
            else if (rezerve_string != "otel dolu" & rezerve_string != "otel bulunamadı" & rezerve_string.Length < 20)
            {

                onay frm = new onay();

                frm.label1.Text = rezerve_string;
                frm.label3.Text = textBox1.Text;
                frm.label4.Text = textBox2.Text;
                frm.Show();
            }
        }

        private void buton1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("otel ismi", 150);
            listView1.Columns.Add("fiyatı", 100);
            listView1.Columns.Add("bos", 100);
        }

        private void button2_Click(object sender, EventArgs e)
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
