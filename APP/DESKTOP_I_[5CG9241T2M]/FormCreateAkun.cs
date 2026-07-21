using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DESKTOP_I__5CG9241T2M_
{
    public partial class FormCreateAkun : Form
    {

        public FormCreateAkun()
        {
            InitializeComponent();

        }

        private void FormCreateAkun_Load(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_password == t_confirmPassword)
            {
                MessageBox.Show("Password dan Comfirm Password harus sama");
                return;
            }

            int cust_active = 0;
            int vendor_active = 0;
            string role = "";
            if (check_customer.Checked)
            {
                cust_active = 1;
                vendor_active = 0;
            }
            else if (check_vendor.Checked)
            {
                cust_active = 1;
                vendor_active = 0;
            }
            else
            {
                MessageBox.Show("pilih role terlebih dahulu");
                return;
            }


            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (check_customer.Checked)
                {
                    string getId = "SELECT  ISNULL (MAX(id), 0) + 1 FROM users";
                    SqlCommand getIdcmd = new SqlCommand(getId, conn);

                    int newId = Convert.ToInt32(getIdcmd.ExecuteScalar());

                    string sql = @"INSERT INTO users (id,phone_number,email,password,cust_name,cust_address,cust_latitude,cust_longitude,cust_active,vendor_active) VALUES (@id,@phone_number,@email,@password,@cust_name,@cust_address,@cust_latitude,@cust_longitude,@cust_active,@vendor_active)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue(@"id", newId);
                    cmd.Parameters.AddWithValue(@"phone_number", t_phoneNumber.Text);
                    cmd.Parameters.AddWithValue(@"email", t_Email.Text);
                    cmd.Parameters.AddWithValue(@"password", t_password.Text);
                    cmd.Parameters.AddWithValue(@"cust_name", t_custName.Text);
                    cmd.Parameters.AddWithValue(@"cust_address", r_custAddress.Text);
                    double cust_latitude = Convert.ToDouble(t_custLatitude.Text);
                    cmd.Parameters.AddWithValue(@"cust_latitude", cust_latitude);
                    double cust_longitude = Convert.ToDouble(t_custLongitude.Text);
                    cmd.Parameters.AddWithValue(@"cust_longitude", cust_longitude);
                    cmd.Parameters.AddWithValue(@"cust_active", 1);
                    cmd.Parameters.AddWithValue(@"vendor_active", 0);


                    cmd.ExecuteNonQuery();
                }
                else if (check_vendor.Checked)
                {
                    string getId = "SELECT  ISNULL (MAX(id), 0) + 1 FROM users";
                    SqlCommand getIdcmd = new SqlCommand(getId, conn);

                    int newId = Convert.ToInt32(getIdcmd.ExecuteScalar());

                    string sql = @"INSERT INTO users (id,phone_number,email,password,vendor_name,vendor_address,vendor_latitude,vendor_longitude,vendor_active,cust_active) VALUES (@id,@phone_number,@email,@password,@vendor_name,@vendor_address,@vendor_latitude,@vendor_longitude,@vendor_active,@cust_active)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue(@"id", newId);
                    cmd.Parameters.AddWithValue(@"phone_number", t_phoneNumber.Text);
                    cmd.Parameters.AddWithValue(@"email", t_Email.Text);
                    cmd.Parameters.AddWithValue(@"password", t_password.Text);
                    cmd.Parameters.AddWithValue(@"vendor_name", t_vendorName.Text);
                    cmd.Parameters.AddWithValue(@"vendor_address", r_vendorAddress.Text);
                    double vendor_latitude = Convert.ToDouble(t_vendorLatitude.Text);
                    cmd.Parameters.AddWithValue(@"vendor_latitude", vendor_latitude);
                    double vendor_longitude = Convert.ToDouble(t_vendorLongitude.Text);
                    cmd.Parameters.AddWithValue(@"vendor_longitude", vendor_longitude);
                    cmd.Parameters.AddWithValue(@"vendor_active", 1);
                    cmd.Parameters.AddWithValue(@"cust_active", 0);



                    cmd.ExecuteNonQuery();
                }
                {
                    MessageBox.Show("Registrasi Berhasil");
                }
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
