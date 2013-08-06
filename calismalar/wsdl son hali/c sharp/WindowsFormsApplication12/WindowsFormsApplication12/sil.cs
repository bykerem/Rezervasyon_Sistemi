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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Yeni_Web_ServisClient myService2 = new ServiceReference1.Yeni_Web_ServisClient();

            MessageBox.Show(myService2.kayit_sil(textBox4.Text).ToString());
        }

        private void sil_Load(object sender, EventArgs e)
        {

        }
    }
}
