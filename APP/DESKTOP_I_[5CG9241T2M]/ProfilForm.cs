using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DESKTOP_I__5CG9241T2M_
{
    public partial class ProfilForm : Form
    {
        private MainForm mainForm;
        private string idUser;
        private string loginUs;
        
        public ProfilForm(MainForm mainform ,string idUser,string loginUs)
        {
            InitializeComponent();
            this.mainForm = mainform;
            this.idUser = idUser;
            this.loginUs = loginUs;
          

            
        }

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True";
        //private object userEmail;
        //private object ex;


        void loadprofile()
        {
            textPhoneNumber.Enabled = false;
            textEmail.Enabled = false;
            textcustName.Enabled = false;
            r_txtaddresscust.Enabled = false;
            textcustLat.Enabled = false;
            textcustLong.Enabled = false;
            textVendorName.Enabled = false;
            rich_vendorAddress.Enabled = false;
            textVendorLat.Enabled = false;
            textVendorLong.Enabled = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            loadprofile();
            label15.Visible = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                String querry = "SELECT phone_number, email,cust_active, cust_name, cust_address, cust_latitude, cust_longitude, " + " vendor_active, vendor_name, vendor_address,vendor_latitude, vendor_longitude FROM users WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUser);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader da = cmd.ExecuteReader())
                        {
                            if (da.Read())
                            {
                                textPhoneNumber.Text = da["phone_number"].ToString();
                                textEmail.Text = da["email"].ToString();

                                checkCustomer.Checked = Convert.ToBoolean(da["cust_active"]);
                                checkVendor.Checked = Convert.ToBoolean(da["vendor_active"]);

                                textcustName.Text = da["cust_name"].ToString();
                                r_txtaddresscust.Text = da["cust_address"].ToString();
                                textcustLat.Text = da["cust_latitude"].ToString();
                                textcustLong.Text = da["cust_longitude"].ToString();

                                textVendorName.Text = da["vendor_name"].ToString();
                                rich_vendorAddress.Text = da["vendor_address"].ToString();
                                textVendorLat.Text = da["vendor_latitude"].ToString();
                                textVendorLong.Text = da["vendor_longitude"].ToString();

                            }
                            else
                            {
                                label15.Visible = true;
                                label15.Text = "Email doesn't have proper format";


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi Kesalahan; " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textEmail.Enabled = true;
            textcustName.Enabled = true;
            r_txtaddresscust.Enabled = true;
            textcustLat.Enabled = true;
            textcustLong.Enabled = true;
            textVendorName.Enabled = true;
            rich_vendorAddress.Enabled = true;
            textVendorLat.Enabled = true;
            textVendorLong.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE users SET cust_name=@cust_name, cust_address=@cust_address, cust_latitude=@cust_latitude,cust_longitude=@cust_longitude, vendor_name=@vendor_name, vendor_address=@vendor_address, vendor_latitude=@vendor_latitude, vendor_longitude=@vendor_longitude WHERE phone_number=@phone_number";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"cust_name", textcustName.Text);
                cmd.Parameters.AddWithValue(@"cust_address", r_txtaddresscust.Text);
                double cust_latitude = Convert.ToDouble(textcustLat.Text);
                cmd.Parameters.AddWithValue(@"cust_latitude", cust_latitude);
                double cust_longitude = Convert.ToDouble(textcustLong.Text);
                cmd.Parameters.AddWithValue(@"cust_longitude", cust_longitude);

                cmd.Parameters.AddWithValue(@"vendor_name", textVendorName.Text);
                cmd.Parameters.AddWithValue(@"vendor_address", rich_vendorAddress.Text);
                double vendor_latitude = Convert.ToDouble(textVendorLat.Text);
                cmd.Parameters.AddWithValue(@"vendor_latitude", vendor_latitude);
                double vendor_longitude = Convert.ToDouble(textVendorLong.Text);
                cmd.Parameters.AddWithValue(@"vendor_longitude", vendor_longitude);

                cmd.Parameters.AddWithValue(@"phone_number", textPhoneNumber.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Data Berhasil Diperbarui");
                }
                else
                {
                    MessageBox.Show("nomor telepon tidak ditemukan");
                }

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEmail.Clear();
            textcustName.Clear();
            r_txtaddresscust.Clear();
            textcustLat.Clear();
            textcustLong.Clear();
            textVendorName.Clear();
            rich_vendorAddress.Clear();
            textVendorLat.Clear();
            textVendorLong.Clear();


        }

        private void button_kembali_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
           
        }
    }
}



