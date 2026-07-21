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
    public partial class TransactionsForm : Form
    {
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True";
        private MainForm mainForm;
        private string idUser;
        private string loginUs;
        public TransactionsForm(MainForm mainForm ,string idUser, string loginUs)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.idUser = idUser;
            this.loginUs = loginUs;
        }

        private int selectedTransactoinsId = 0;
        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
                if (loginUs == "Customer")
                {
                    string query = @"SELECT p.product_name, u.vendor_name, t.quantity, p.price_per_unit,t.total_price, t.delivery_cost, t.status FROM transactions t INNER JOIN products p ON t.product_id = p.id INNER JOIN users u ON t.vendor_id =u.id WHERE status <> 'pending'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (loginUs == "Vendor")
                {
                    string query = @"SELECT p.product_name, u.cust_name, t.quantity, p.price_per_unit,t.total_price, t.delivery_cost, t.status FROM transactions t INNER JOIN products p ON t.product_id = p.id INNER JOIN users u ON t.customer_id =u.id WHERE status <> 'pending'";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }



            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT t.id, p.product_name, u.vendor_name, t.quantity, p.price_per_unit, t.total_price, t.delivery_cost, t.status FROM transactions t INNER JOIN products p ON t.product_id = p.id INNER JOIN users u ON t.vendor_id = u.id WHERE status = 'pending'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGV_pending.DataSource = dt;
                DGV_pending.Columns["id"].Visible = false;
            }



            if (loginUs == "Customer")
            {
                button_Approve.Visible = false;
                button_Decline.Visible = false;
            }
            else if (loginUs == "Vendor")
            {
                button_cabcelTransaktions.Visible = false;
            }

        }

        private void DGV_pending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_pending.Rows[e.RowIndex];

                selectedTransactoinsId = Convert.ToInt32(row.Cells["id"].Value);

                label_productName.Text = row.Cells["product_name"].Value?.ToString() ?? "";
                label_VendorName.Text = row.Cells["vendor_name"].Value?.ToString() ?? "";
                label_Quantity.Text = row.Cells["quantity"].Value?.ToString() ?? "";
                label_pricePerUnit.Text = row.Cells["price_per_unit"].Value?.ToString() ?? "";
                label_TotalTransaksi.Text = row.Cells["total_price"].Value?.ToString() ?? "";
                label_DeliveryCost.Text = row.Cells["delivery_cost"].Value?.ToString() ?? "";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button_cabcelTransaktions_Click(object sender, EventArgs e)
        {
            if (selectedTransactoinsId == 0)
            {
                MessageBox.Show("Pilih Transaksi Terlebih Dahulu");
                return;
            }
            DialogResult result = MessageBox.Show("Apakan Anda Yakin Ingin Membatalkan Transaksi ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE transactions SET status ='abort',updated_at = GETDATE() WHERE id = @id AND status = 'pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", selectedTransactoinsId);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Transaksi Berhasil Dibatalkan");

                    loadData();

                    selectedTransactoinsId = 0;
                    label_productName.Text = "";
                    label_VendorName.Text = "";
                    label_Quantity.Text = "";
                    label_pricePerUnit.Text = "";
                    label_TotalTransaksi.Text = "";
                    label_DeliveryCost.Text = "";
                }
                else
                {
                    MessageBox.Show("Transaksi Gagal Dibatalkan");
                }
            }
        }

        private void button_Approve_Click(object sender, EventArgs e)
        {
            if (selectedTransactoinsId == 0)
            {
                MessageBox.Show("pilih transaksi terlebih dahulu");
                return;
            }
            DialogResult result = MessageBox.Show("Apakah Anda Ingin Menyetujui Transaksi Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE transactions SET status = 'success',updated_at = GETDATE() WHERE id = @id AND status = 'pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", selectedTransactoinsId);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Transaksi Disetujui");

                    loadData();

                    selectedTransactoinsId = 0;
                    label_productName.Text = "";
                    label_VendorName.Text = "";
                    label_Quantity.Text = "";
                    label_pricePerUnit.Text = "";
                    label_TotalTransaksi.Text = "";
                    label_DeliveryCost.Text = "";

                }
                else
                {
                    MessageBox.Show("Transaksi gagal disetujui");
                }
            }
        }

        private void button_Decline_Click(object sender, EventArgs e)
        {
            if (selectedTransactoinsId == 0)
            {
                MessageBox.Show("Pilih Transaksi Terlebih Dahulu");
                return;
            }
            DialogResult result = MessageBox.Show("Apakan Anda Yakin Ingin Menolak Transaksi ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE transactions SET status ='abort',updated_at = GETDATE() WHERE id = @id AND status = 'pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", selectedTransactoinsId);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Transaksi Berhasil Ditolak");

                    loadData();

                    selectedTransactoinsId = 0;
                    label_productName.Text = "";
                    label_VendorName.Text = "";
                    label_Quantity.Text = "";
                    label_pricePerUnit.Text = "";
                    label_TotalTransaksi.Text = "";
                    label_DeliveryCost.Text = "";
                }
                else
                {
                    MessageBox.Show("Transaksi Gagal Ditolak");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}

