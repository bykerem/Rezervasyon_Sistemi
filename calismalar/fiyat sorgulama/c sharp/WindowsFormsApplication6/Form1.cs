using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
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
            
            // 

         
 // MessageBox.Show(myService2.operasyon2("cehars").ToString());
            MessageBox.Show(myService2.operasyon2(textBox1.Text).ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
