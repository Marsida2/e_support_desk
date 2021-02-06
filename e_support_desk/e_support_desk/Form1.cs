using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace e_support_desk
{
    public partial class Form1 : Form
    {
        private string conn_string = "Data Source=DESKTOP-JS1HJ89\\SQLEXPRESS01;Initial Catalog=e_support;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hyr_Click(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                MessageBox.Show(this, "Vendosni email-in!", "Error");
                return;
            }
            else if (fjalekalimi.Text == "")
            {
                MessageBox.Show(this, "Vendosni fjalekalimin!", "Error");
                return;
            }
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "get_user";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("email", email.Text);
                cmd.Parameters.AddWithValue("fjalekalimi", fjalekalimi.Text);
                int id_punonjesi = 0;
                try
                {
                    conn.Open();
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show(this, "Te dhena te gabuara!", "Error");
                        fjalekalimi.Text = "";
                        return;
                    }
                    id_punonjesi = (int) cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }

                //ekziston useri
                //do te hapet forma e rradhes
                MessageBox.Show(this, "id_punonjesi "+id_punonjesi, "Sukses");
                Menu menu = new Menu(id_punonjesi, conn_string);
                this.Visible = false;
                menu.ShowDialog();
                this.Dispose();
            }
        }
    }
}
