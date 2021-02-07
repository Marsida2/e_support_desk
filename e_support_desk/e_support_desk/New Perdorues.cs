using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace e_support_desk
{
    public partial class New_Perdorues : Form
    {
        private string conn_string;
        public New_Perdorues(string conn_str)
        {
            InitializeComponent();
            conn_string = conn_str;
        }

        private void New_Perdorues_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet1.roli' table. You can move, or remove it, as needed.
            this.roliTableAdapter.Fill(this.e_supportDataSet1.roli);

        }

        private bool valido_inputin()
        {
            if (textBox1.Text == "" | textBox2.Text == "" | 
                textBox3.Text == "" | comboBox1.SelectedIndex == (-1))
                return false;
            return true;
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

        private void btn_krijo_account_Click(object sender, EventArgs e)
        {
            if (!valido_inputin())
            {
                MessageBox.Show(this, "Mungese te dhenash!", "ERROR");
                return;
            }
            int id_roli = (int)comboBox1.SelectedValue;
            //MessageBox.Show(this, "selected roli: " + id_roli);

            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "shto_perdorues";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("emri", textBox1.Text);
                cmd.Parameters.AddWithValue("mbiemri", textBox2.Text);
                cmd.Parameters.AddWithValue("email", textBox3.Text);
                cmd.Parameters.AddWithValue("fjalekalimi", this.gjenero_fjalekalim());
                cmd.Parameters.AddWithValue("tel", textBox4.Text);
                cmd.Parameters.AddWithValue("roli", id_roli);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Perdoruesi u shtua me sukses!", "SUKSES");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }
    }
}