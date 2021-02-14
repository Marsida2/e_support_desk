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
    public partial class Faturim : Form
    {
        private string conn_string;
        private int id_shitje = 0;
        private int id_punonjesi;
        private int id_fature = 0;

        public Faturim(string conn_str, int id_perd)
        {
            InitializeComponent();
            this.conn_string = conn_str;
            id_punonjesi = id_perd;
            ngarko_info_klienti();
        }


        private void ngarko_info_klienti()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from klienti_info";
                cmd.CommandType = CommandType.Text;
                List<Klient> klientet = new List<Klient>();
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        klientet.Add(new Klient((string)reader["klienti"], (int)reader["id_klienti"]));
                    }
                    klientet.Add(new Klient("Shto klient te ri", 0));
                    cb_klienti.DataSource = klientet;
                    cb_klienti.DisplayMember = "Emri";
                    cb_klienti.ValueMember = "Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this, "U zgjodh indeksi: " + cb_klienti.SelectedValue, "Error");
            if((int)cb_klienti.SelectedValue == 0)
            {
                New_Klient klient = new New_Klient(conn_string);
                klient.ShowDialog();
                ngarko_info_klienti();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_pajisja.Enabled == false)
            {
                cb_pajisja.Enabled = true;
                nr_sasia.Enabled = true;
                chb_garanci.Enabled = true;
            }
            if (cb_sherbime.Enabled == true)
                cb_sherbime.Enabled = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pajisja.Enabled == true)
            {
                cb_pajisja.Enabled = false;
                nr_sasia.Enabled = false;
                chb_garanci.Enabled = false;
            }
            if (cb_sherbime.Enabled == false)
                cb_sherbime.Enabled = true;
        }

        private void Faturim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.sherbimi' table. You can move, or remove it, as needed.
            this.sherbimiTableAdapter.Fill(this.e_supportDataSet.sherbimi);
            // TODO: This line of code loads data into the 'e_supportDataSet.pajisja' table. You can move, or remove it, as needed.
            this.pajisjaTableAdapter.Fill(this.e_supportDataSet.pajisja);

        }

        //butoni shto
      private void button3_Click(object sender, EventArgs e)
      {
            //if(rb_pajisje.Checked && cb_pajisja.SelectedValue)
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            if (id_shitje != 0)
                cmd.CommandText = "SET IDENTITY_INSERT shitje ON; ";
            cmd.CommandText += "Insert into shitje(";
             if(id_shitje != 0)
                cmd.CommandText += "id_shitje, ";
             if (rb_pajisje.Checked)
                cmd.CommandText += "id_pajisje, sasia, garanci) values(";
             else
                cmd.CommandText += "id_sherbimi) values(";
            if (id_shitje != 0)
                cmd.CommandText += "@id_shitje, ";
            if (rb_pajisje.Checked)
                cmd.CommandText += "@pajisje, @sasi, @garanci);";
            else
                cmd.CommandText += "@sherbim);";
            if (id_shitje == 0)
                cmd.CommandText += "Select CAST(scope_identity() AS int);";

            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                cmd.Connection = conn;
                if(id_shitje != 0)
                    cmd.Parameters.AddWithValue("@id_shitje", id_shitje);
                if(rb_sherbim.Checked)
                    cmd.Parameters.AddWithValue("@sherbim", cb_sherbime.SelectedValue);
                else
                {
                    cmd.Parameters.AddWithValue("@pajisje", cb_pajisja.SelectedValue);
                    cmd.Parameters.AddWithValue("@sasi", nr_sasia.Value);
                    cmd.Parameters.AddWithValue("@garanci", chb_garanci.Checked);
                }
                try
                {
                    conn.Open();
                    if (id_shitje == 0)
                        id_shitje = (int)cmd.ExecuteScalar();
                    else
                        cmd.ExecuteNonQuery();
                reseto_vlerat();
                disable_fushat();
                    MessageBox.Show(this, "vlera e cb pajisje :" + cb_pajisja.SelectedValue, "kot");
                MessageBox.Show(this, "Query u ekzekutua me sukses!" + id_shitje, "SUKSES");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                }
                }
      }

        private void btn_faturo_Click(object sender, EventArgs e)
        {
            if ((string)cb_klienti.SelectedValue != "0" && id_shitje != 0)
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into fature(id_klienti, id_punonjesi, id_shitje) values(@id_klienti, @id_punonjesi, @id_shitje)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_klienti", cb_klienti.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_punonjesi", id_punonjesi);
                    cmd.Parameters.AddWithValue("@id_shitje", id_shitje);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(this, "Fatura u shtua me sukses!", "SUKSES");
                        id_fature = id_shitje;
                        id_shitje = 0;
                        groupBox1.Enabled = false;
                        btn_anullo.Enabled = false;
                        btn_faturo.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                        return;
                    }
                }
            }
        }

        private void btn_anullo_Click(object sender, EventArgs e)
        {
            if(id_shitje != 0 )
                if (MessageBox.Show("Nese ktheheni fatura do te anullohet. Doni te ktheheni?",
                                "Konfirmoni anullimin e fatures", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            anullo_faturen();
            reseto_vlerat();
            disable_fushat();
        }

        private void anullo_faturen()
        {
            if (id_shitje != 0)
            {
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from shitje where id_shitje = @id_shitje;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_shitje", id_shitje);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(this, "Fatura u kthye me sukses!", "SUKSES");
                        id_shitje = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                        return;
                    }
                }
            }

        }

        private void disable_fushat()
        {
            rb_pajisje.Checked = false;
            rb_sherbim.Checked = false;
            cb_pajisja.Enabled = false;
            nr_sasia.Enabled = false;
            chb_garanci.Enabled = false;
            cb_sherbime.Enabled = false;
        }

        private void reseto_vlerat()
        {
            nr_sasia.Value = 1;
            chb_garanci.Checked = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_faturo.Enabled)
                if (MessageBox.Show("Nese ktheheni fatura do te anullohet. Doni te ktheheni?",
                    "Konfirmoni anullimin e fatures", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return; 
            anullo_faturen();        
            this.Close();
        }

        private void Faturim_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(this, "Fatura juaj do te humbase nese nuk e keni faturuar!", "Mbyllja e dritares");
            anullo_faturen();
        }
    }

}