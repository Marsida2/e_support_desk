using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_support_desk
{
    public partial class New_Klient : Form
    {
        private string conn_string;
        public New_Klient(string conn_str)
        {
            InitializeComponent();
            conn_string = conn_str;
        }

        private void klientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);

        }

        private void New_Klient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.klienti' table. You can move, or remove it, as needed.
            this.klientiTableAdapter.Fill(this.e_supportDataSet.klienti);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_krijo_account_Click(object sender, EventArgs e)
        {
            //validim i fushave
            if (textBox1.Text == "" | textBox2.Text == "" |
                textBox3.Text == "" | textBox4.Text == "")
            {
                MessageBox.Show(this, "Te dhena ta paplotesuara!", "ERROR");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into klienti(emri, mbiemri, email, tel, fjalekalimi) values(@em, @mb, @email, @tel, @fjkl);" +
                                  "Select CAST(scope_identity() AS int)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@em", textBox1.Text);
                cmd.Parameters.AddWithValue("@mb", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@tel", textBox4.Text);
                cmd.Parameters.AddWithValue("@fjkl", gjenero_fjalekalim());
                int new_id;
                try
                {
                    conn.Open();
                    new_id = (int)cmd.ExecuteScalar();
                    MessageBox.Show(this, "Klienti u shtua me sukses!" + new_id, "SUKSES");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        private string gjenero_fjalekalim()
        {
            string simbole = "";
            string fjalekalimi = "";
            Random rand = new Random();

            // an array of different character types    
            simbole = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?";
            int nr_simbolesh = simbole.Length;
            for (int i = 0; i < 9; i++)
            {
                int n = rand.Next(0, nr_simbolesh); //intervali [0; nr_simbolesh[
                fjalekalimi += simbole[n]; // add the character to the password string
            }
            return fjalekalimi; // return the generated password
        }

    }
}
