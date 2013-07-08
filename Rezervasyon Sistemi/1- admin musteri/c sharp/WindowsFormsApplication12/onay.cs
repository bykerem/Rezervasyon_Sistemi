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
    public partial class onay : Form
    {
        admin f1 = new admin();

        public onay()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "test";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();
           



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

           // MessageBox.Show(label3.Text);
           // MessageBox.Show(label4.Text);

            MessageBox.Show(myService2.Yer_Ayirt(label3.Text, label4.Text).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
