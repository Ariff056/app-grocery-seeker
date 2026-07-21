using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows.Forms;

namespace DESKTOP_I__5CG9241T2M_
{
    public partial class ProductForm : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True";

        private String loginUs;
        private String idUser;
        private MainForm mainForm;


        private int selectProductId = -1;
        bool isEditMOde = false;

        public ProductForm(MainForm mainForm ,string loginUs, string idUser)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.loginUs = loginUs;
            this.idUser = idUser;
            NUP_quantity.ValueChanged += NUP_quantity_ValueChanged;

        }

        public class TransaksiArea
        {
            private const double R = 6371.0;

            public double HitungJarak(double lat1, double lon1, double lat2, double lon2)
            {
                double dLat = ToRadians(lat2 - lat1);
                double dLon = ToRadians(lon2 - lon1);

                double phi1 = ToRadians(lat1);
                double phi2 = ToRadians(lat2);

                double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(phi1) * Math.Cos(phi2) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                double d = R * c;

                return d;
            }
            public double HitungBiayaPengiriman(double jarak)
            {
                return (jarak / 100.00) * 15000;
            }

            public double HitungTotalProduk(int quantity, double pricePerUnit)
            {
                return quantity * pricePerUnit;
            }

            private double ToRadians(double val)
            {
                return (Math.PI / 180) * val;
            }
        }

        private void ClearFields()
        {
            text_detailNama.Clear();
            nUD_prince.Value = 0;
        }

        private void EnableInput(bool enable)
        {
            text_detailNama.Enabled = enable;
            nUD_prince.Enabled = enable;
            button_save.Enabled = enable;
        }

        private void RefleshGrid()
        {
            loadData();
        }


        private void FinishAction()
        {
            ClearFields();
            EnableInput(false);
            isEditMode = false;
            selectProductId = -1;
            RefleshGrid();
        }

        bool isEditMode = true;


        private void Calculate()
        {
            try
            {
                int quantity = (int)NUP_quantity.Value;
                double price = Convert.ToDouble(nUD_prince.Value);

                TransaksiArea ta = new TransaksiArea();


                double total = ta.HitungTotalProduk(quantity, price);


                double lat1 = 0, lon1 = 0;
                double lat2 = 0, lon2 = 0;


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT cust_latitude, cust_longitude FROM users WHERE id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUser);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["cust_latitude"] != DBNull.Value)
                                    lat1 = Convert.ToDouble(reader["cust_latitude"]);

                                if (reader["cust_longitude"] != DBNull.Value)
                                    lon1 = Convert.ToDouble(reader["cust_longitude"]);
                            }
                        }
                    }
                }


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT vendor_latitude, vendor_longitude 
                FROM users 
                WHERE id = (
                    SELECT vendor_id FROM products WHERE id = @product_id
                )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", selectProductId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["vendor_latitude"] != DBNull.Value)
                                    lat2 = Convert.ToDouble(reader["vendor_latitude"]);

                                if (reader["vendor_longitude"] != DBNull.Value)
                                    lon2 = Convert.ToDouble(reader["vendor_longitude"]);
                            }
                        }
                    }
                }


                if (lat1 == 0 && lon1 == 0)
                {
                    MessageBox.Show("Lokasi customer belum tersedia!");
                    return;
                }

                if (lat2 == 0 && lon2 == 0)
                {
                    MessageBox.Show("Lokasi vendor belum tersedia!");
                    return;
                }


                double jarak = ta.HitungJarak(lat1, lon1, lat2, lon2);


                double deliveryCost = ta.HitungBiayaPengiriman(jarak);


                label_totaTransaksi.Text = total.ToString("N0");
                label_delevery.Text = deliveryCost.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Calculate: " + ex.Message);
            }
        }

        private void NUP_quantity_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void loadData()
        {
            if (loginUs == "Customer")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT id,vendor_id,product_name,category_id,unit_type,price_per_unit,unit_stock FROM products";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_product.DataSource = dt;

                }


            }
            else if (loginUs == "Vendor")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT p.id,p.vendor_id,p.product_name,p.category_id,c.name AS category_name,p.unit_type,p.price_per_unit,p.unit_stock,p.is_active FROM products p INNER JOIN categories c ON p.category_id = c.id INNER JOIN users u ON p.vendor_id = u.id";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);
                    dgv_product.DataSource = dt;

                }
            }

            if (loginUs == "Customer")
            {
                groupBox_Detail.Enabled = false;
                b_AddItem.Visible = false;
                b_EditItem.Visible = false;
                b_DeleteItem.Visible = false;
                button_save.Visible = false;
                button_cancel.Visible = false;
                cbx_status.Visible = false;
                label_Status.Visible = false;
            }
            else if (loginUs == "Vendor")
            {
                groupBox_transactional.Visible = false;
            }

        }

        private void loadCategory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string querry = "SELECT id, name FROM categories";

                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox_categories.DataSource = dt;
                comboBox_categories.DisplayMember = "name";
                comboBox_categories.ValueMember = "id";
                comboBox_categories.SelectedIndex = -1;
            }
        }

        private void loadStatus()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT status FROM transactions";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbx_status.DataSource = dt;
                cbx_status.DisplayMember = "status";
                cbx_status.ValueMember = "status";
                cbx_status.SelectedIndex = -1;
            }
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_product.Rows[e.RowIndex];
                selectProductId = Convert.ToInt32(row.Cells["id"].Value);
                text_detailNama.Text = row.Cells["product_name"].Value?.ToString() ?? "";
                if (loginUs == "Customer")
                {
                    comboBox_categories.Text = row.Cells["category_id"].Value?.ToString() ?? "";
                }
                else if (loginUs == "Vendor")
                {
                    comboBox_categories.SelectedValue = (row.Cells["category_id"].Value);
                }
                nUD_prince.Value = Convert.ToDecimal(row.Cells["price_per_unit"].Value ?? 0);
                nUD_UnitStok.Value = Convert.ToDecimal(row.Cells["unit_stock"].Value ?? 0);
                double Quantity = Convert.ToDouble(NUP_quantity.Value);
                double totalHarga = Quantity * Convert.ToDouble(nUD_prince.Value);


                string unitType = row.Cells["unit_type"].Value?.ToString() ?? "";
                check_countable.Checked = false;
                check_Measurable.Checked = false;

                if (unitType.ToLower() == "countable")
                {
                    check_countable.Checked = true;
                }
                else if (unitType.ToLower() == "measurable")
                {
                    check_Measurable.Checked = true;
                }



            }
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadData();
            loadStatus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_detailNama.Clear();
            comboBox_categories.SelectedIndex = -1;
            comboBox_categories.Text = "";
            nUD_prince.Value = 0;
            nUD_UnitStok.Value = 0;

            check_countable.Checked = false;
            check_Measurable.Checked = false;

            NUP_quantity.Value = 0;

            label_total.Text = "";
            label_delevery.Text = "";
        }

        private void button_Buy_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string query = " SELECT COUNT (*) FROM transactions WHERE customer_id = @customer_id AND Status = 'pending'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", idUser);
                    conn.Open();
                    int Count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (Count >= 10)
                    {
                        MessageBox.Show("anda sudah memiliki 10 transaksi pending");
                        return;
                    }
                }

                string insertQuery = @"INSERT INTO transactions(customer_id,vendor_id,product_id,quantity,total_price,delivery_cost,status) SELECT @customer_id,p.vendor_id,p.id,@quantity,@total_price,@delivery_cost,'pending' FROM products p WHERE p.id = @product_id";

                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.Add("@customer_id", SqlDbType.Int).Value = idUser;
                    cmdInsert.Parameters.Add("@product_id", SqlDbType.Int).Value = selectProductId;
                    cmdInsert.Parameters.Add("@quantity", SqlDbType.Int).Value = NUP_quantity.Value;
                    cmdInsert.Parameters.Add("@total_price", SqlDbType.Decimal).Value = nUD_prince.Value;
                    cmdInsert.Parameters.Add("@delivery_cost", SqlDbType.Decimal).Value = Convert.ToDecimal(label_delevery.Text);

                    cmdInsert.ExecuteNonQuery();
                }
                MessageBox.Show("transaksi berhasil tersimpan");
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinishAction();
        }

        private void b_AddItem_Click(object sender, EventArgs e)
        {
            isEditMode = false;
            selectProductId = -1;
            ClearFields();
            EnableInput(true);
        }

        private void b_EditItem_Click(object sender, EventArgs e)
        {
            if (dgv_product.CurrentRow != null)
            {
                if (selectProductId == -1)
                {
                    MessageBox.Show("pilih product terlebih dahulu");
                    return;
                }
                isEditMode = true;
                EnableInput(true);

            }
        }

        private void b_DeleteItem_Click(object sender, EventArgs e)
        {
            if (selectProductId == -1)
            {
                MessageBox.Show("Pilih produk terlebih dahulu");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Hapus produk ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string deleteTransactions =
                    "DELETE FROM transactions WHERE product_id = @id";
                SqlCommand cmd = new SqlCommand(deleteTransactions, conn);

                cmd.Parameters.AddWithValue("@id", selectProductId);

                cmd.ExecuteNonQuery();


                string query =
                    "DELETE FROM products WHERE id = @id";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@id", selectProductId);

                command.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Produk berhasil dihapus");

            FinishAction();
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_detailNama.Text))
            {
                MessageBox.Show("Nama produk wajib diisi");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd;

                if (isEditMode)
                {
                    string query = @"UPDATE products SET product_name = @name,category_id = @category,unit_type = @unitType,price_per_unit = @price, unit_stock = @stock,updated_at = GETDATE() WHERE id = @id";

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", selectProductId);
                }
                else
                {
                    string getIdquery = "SELECT ISNULL (MAX(id) ,0) + 1 FROM products";
                    SqlCommand getIdcmd = new SqlCommand(getIdquery, conn);

                    int newId = Convert.ToInt32(getIdcmd.ExecuteScalar());

                    string insertquery = @" INSERT INTO products ( id,vendor_id,category_id,unit_type,product_name,price_per_unit, unit_stock,is_active,created_at )VALUES(@id,@vendor,@category,@unitType,@name,@price,@stock,1,GETDATE())";

                    cmd = new SqlCommand(insertquery, conn);

                    MessageBox.Show("SelectedValue = " + comboBox_categories.SelectedValue + "\nSelectedItem = " + comboBox_categories.Text);
                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@vendor", idUser);
                    cmd.Parameters.AddWithValue("@category", Convert.ToInt32(comboBox_categories.SelectedValue));
                    cmd.Parameters.AddWithValue("@unitType", check_countable.Checked ? "Countable" : "Measurable");
                    cmd.Parameters.AddWithValue("@name", text_detailNama.Text);
                    cmd.Parameters.AddWithValue("@price", nUD_prince.Value);
                    cmd.Parameters.AddWithValue("@stock", nUD_UnitStok.Value);
                    cmd.Parameters.AddWithValue("@active", true);



                    cmd.ExecuteNonQuery();

                }
                if (comboBox_categories.SelectedIndex == -1)
                {
                    MessageBox.Show("Silakan pilih kategori terlebih dahulu.");
                    return;
                }



            }

            MessageBox.Show(
                isEditMode
                ? "Produk berhasil diubah"
                : "Produk berhasil ditambahkan");

            FinishAction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
