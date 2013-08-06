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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text == "19")
            {
                admin frm = new admin();

                frm.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
