using System.Data;
using System.Data.SqlClient;

namespace DESKTOP_I__5CG9241T2M_
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=grocerseeker;Integrated Security=True;TrustServerCertificate=True");
        DataTable dtable=new DataTable();
        
        
        
    
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //string inputPhone = tex_Phone.Text;
            //string inputPassword = tex_Password.Text;

            //if(inputPhone== "true" && inputPassword == "true")
            //{
            //    label5.Visible = false;
            //    MessageBox.Show("SUCCES LOGIN");
            //}
            //else
            //{
            //    label5.Visible =  true;
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormCreateAkun FCA = new FormCreateAkun();
            FCA.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                String StatusColumn = "";
                if(com_Login.Text.Trim().ToLower()== "customer")
                {
                    StatusColumn = "cust_active";
                }
                else if(com_Login.Text.Trim().ToLower()=="vendor")
                {
                    StatusColumn = "vendor_active";
                }
                else
                {
                    MessageBox.Show("Pilihan Tidak Valid!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

            try
            {
                if (tex_Password.Text == "")
                {
                    MessageBox.Show("isi password terlebih dahulu");
                    return;
                }

                String SqlQuerry = $"SELECT *FROM users WHERE phone_number=@Phone AND password=@Password AND {StatusColumn}=1";
                conn.Open();
                SqlCommand cmd = new SqlCommand(SqlQuerry, conn);
                cmd.Parameters.AddWithValue("@Phone", tex_Phone.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", tex_Password.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    String nama = "";
                    String LoginUs = com_Login.Text;

                    string idUser = dtable.Rows[0]["id"].ToString();

                    if (LoginUs.ToLower() == "customer")
                    {
                        nama = dtable.Rows[0]["cust_name"].ToString();
                    }
                    else if(LoginUs.ToLower()== "vendor")
                    {
                        nama = dtable.Rows[0]["vendor_name"].ToString();
                    }

                    MainForm mf = new MainForm(nama, LoginUs, idUser);
                    MessageBox.Show(mf.Name);
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Data Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label5.Visible = true;
                    label5.Text = "sorry! we couidn't find you credential";
                    tex_Phone.Clear();
                    tex_Password.Clear();
                    tex_Phone.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }



        }
    }
}
