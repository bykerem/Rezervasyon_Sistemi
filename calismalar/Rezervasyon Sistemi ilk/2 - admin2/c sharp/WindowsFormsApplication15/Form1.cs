using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            int sayi = Int32.Parse((myService2.listele_isim()).Length.ToString());

            int sayac = 0;

            while (sayac < sayi)
            {

                listBox1.Items.Add((myService2.listele_isim())[sayac]);
                sayac = sayac + 1;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            listBox1.Items.Clear();
            // MessageBox.Show((myService2.listele_isim()).Length.ToString());

            int sayi = Int32.Parse((myService2.listele_isim()).Length.ToString());

            int sayac = 0;
             
            while (sayac < sayi)
            {
                
                listBox1.Items.Add((myService2.listele_isim())[sayac]);
                sayac = sayac + 1;


            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // listBox1.Items.Remove(listBox1.SelectedItem);

            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            String sec = textBox1.Text;
            listBox1.Items.Remove(sec);

            MessageBox.Show(myService2.sil(sec));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
            // 

            textBox2.Text = myService2.fiyat_bul(listBox1.Text);

            // myService2.Close();

            // ServiceReference1.Yeni_Web_ServisClient myService3 = new ServiceReference1.Yeni_Web_ServisClient();
            
            // MessageBox.Show(listBox1.Text);
            textBox3.Text = myService2.bos_bul(listBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
            MessageBox.Show(myService2.guncelle(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
            MessageBox.Show(myService2.ekle(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString()));
        }
      
    }
}
