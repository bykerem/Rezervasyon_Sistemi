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

        private void button6_Click(object sender, EventArgs e)
        {

             ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

           


            // List<string> liste = new List<string>();
            // liste = myService2.listele_isim();

            //  MessageBox.Show((myService2.listele_isim()).Length.ToString());

            //  MessageBox.Show(myService2.listele_fiyat().ToString());
            int sayi = Int32.Parse((myService2.listele_isim()).Length.ToString());

             // MessageBox.Show(sayi.ToString());
            int sayac = 0;
             

            // MessageBox.Show(liste4);

            while (sayac < sayi)
            {
            // listView1.Items.Add(ekle);

            ListViewItem ekle = new ListViewItem();

            ekle.Text = (myService2.listele_isim())[sayac];
            ekle.SubItems.Add((myService2.listele_fiyat())[sayac]);
            ekle.SubItems.Add((myService2.listele_bos())[sayac]);
            sayac = sayac + 1;
            
            listView1.Items.Add(ekle);

            }
            
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
        

            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
            String rezerve_string = myService2.onay(textBox7.Text, textBox8.Text).ToString();

            if (rezerve_string == "otel bulunamadı")
            {
                MessageBox.Show("otel bulunamadı");
            }
            if (rezerve_string == "otel dolu")
            {
                MessageBox.Show("otel dolu");
            }
            if (rezerve_string.Length > 20)
            {
                MessageBox.Show(rezerve_string);
            }
            if (rezerve_string != "otel dolu" & rezerve_string != "otel bulunamadı" & rezerve_string.Length < 20)
            {

                onay frm = new onay();

                frm.label1.Text = rezerve_string;
                frm.label3.Text = textBox7.Text;
                frm.label4.Text = textBox8.Text;
                frm.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("otel ismi", 150);
            listView1.Columns.Add("fiyatı", 100);
            listView1.Columns.Add("bos/dolu", 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.doluluk_durumu(textBox4.Text).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.sorgu(textBox3.Text).ToString());
        }

        
    }
}
