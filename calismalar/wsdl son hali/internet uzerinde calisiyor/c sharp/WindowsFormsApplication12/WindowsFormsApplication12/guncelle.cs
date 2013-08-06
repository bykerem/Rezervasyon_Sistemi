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
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.guncelle(textBox5.Text, textBox6.Text, textBox7.Text).ToString());
        }

        private void guncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
