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
    public partial class New_Sherbim : Form
    {
        private string conn_string;
        private int roli;
        public New_Sherbim(string conn_str, int roli)
        {
            InitializeComponent();
            conn_string = conn_str;
            this.roli = roli;
        }

        private void btn_krijo_account_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show(this, "Plotesoni llojin e sherbimit", "ERROR");
                return;
            }

            float kosto = 0;
            try
            {
                kosto = (float)Convert.ToDouble(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR");
                return;
            }
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "shto_sherbim";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("lloji", textBox1.Text);
                cmd.Parameters.AddWithValue("kostoja", kosto);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Sherbimi u shtua me sukses!", "SUKSES");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sherbimiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sherbimiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);

        }

        private void New_Sherbim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.sherbimi' table. You can move, or remove it, as needed.
            this.sherbimiTableAdapter.Fill(this.e_supportDataSet.sherbimi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
