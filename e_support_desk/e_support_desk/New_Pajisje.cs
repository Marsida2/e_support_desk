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
    public partial class New_Pajisje : Form
    {
        private string conn_string;
        private int roli;
        public New_Pajisje(string conn_str, int roli)
        {
            InitializeComponent();
            conn_string = conn_str;
            this.roli = roli;
            if (roli != 0)
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
        }

        private void pajisjaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pajisjaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);
            
        }

        private void New_Pajisje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.pajisja' table. You can move, or remove it, as needed.
            this.pajisjaTableAdapter.Fill(this.e_supportDataSet.pajisja);

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
            float kosto;
            int sasi;
            try
            {
                kosto = (float)Convert.ToDouble(textBox4.Text);
                sasi = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR");
                return;
            }
            //shtimi ne databaze
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "shto_pajisje";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("kod", textBox1.Text);
                cmd.Parameters.AddWithValue("emertimi", textBox2.Text);
                cmd.Parameters.AddWithValue("sasi", sasi);
                cmd.Parameters.AddWithValue("cmimi", kosto);

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
    }
}
