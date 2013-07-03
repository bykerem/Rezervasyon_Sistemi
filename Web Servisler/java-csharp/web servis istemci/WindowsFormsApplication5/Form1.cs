using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ServiceReference1.Service1SoapClient service = new ServiceReference1.Service1SoapClient();

            //MessageBox.Show(service.HelloWorld());

            ServiceReference1.Yeni_Web_Servis_AdiClient myService = new ServiceReference1.Yeni_Web_Servis_AdiClient();

            MessageBox.Show(myService.operasyon1("cehars").ToString());
        }
    }
}
