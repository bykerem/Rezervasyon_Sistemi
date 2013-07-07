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

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();


            MessageBox.Show(myService2.ekle(textBox1.Text, textBox2.Text).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.sorgu(textBox3.Text).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.doluluk_durumu(textBox4.Text).ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.guncelle(textBox5.Text, textBox6.Text).ToString());

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

                Form2 frm = new Form2();

                frm.label1.Text = rezerve_string;
                frm.label3.Text = textBox7.Text;
                frm.label4.Text = textBox8.Text;
                frm.ShowDialog();
            }
            
        }
    }
}
