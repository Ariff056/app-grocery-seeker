using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DESKTOP_I__5CG9241T2M_
{
    public partial class MainForm : Form
    {
        private string idUser;
        private string loginUs;

        public MainForm(string nama, string LoginUs, string idUser)
        {
            InitializeComponent();
            label3.Text = nama;
            label4.Text = LoginUs;
            this.idUser = idUser;
            this.loginUs = LoginUs;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilForm pf = new ProfilForm(this,idUser,loginUs);
            pf.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm(this,loginUs,idUser);
            product.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TransactionsForm tf = new TransactionsForm(this,idUser,loginUs);
            tf.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
