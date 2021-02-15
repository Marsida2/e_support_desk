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
    public partial class New_Ceshtje : Form
    {
        private string conn_string;

        public New_Ceshtje(string conn_str)
        {
            InitializeComponent();
            conn_string = conn_str;
            ngarko_info_klienti();
            dt_afati.MinDate = DateTime.Today;
        }

        private void New_Ceshtje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.punonjes_info' table. You can move, or remove it, as needed.
            this.punonjes_infoTableAdapter.Fill(this.e_supportDataSet.punonjes_info);
            // TODO: This line of code loads data into the 'e_supportDataSet.punonjesi' table. You can move, or remove it, as needed.
            this.punonjesiTableAdapter.Fill(this.e_supportDataSet.punonjesi);
            // TODO: This line of code loads data into the 'e_supportDataSet.sherbimi' table. You can move, or remove it, as needed.
            this.sherbimiTableAdapter.Fill(this.e_supportDataSet.sherbimi);
            // TODO: This line of code loads data into the 'e_supportDataSet.prioriteti' table. You can move, or remove it, as needed.
            this.prioritetiTableAdapter.Fill(this.e_supportDataSet.prioriteti);
            MessageBox.Show(this, "Prioriteti: " + cb_prioriteti.SelectedValue, "Error");
            MessageBox.Show(this, "punonjesi " + cb_pergjegjesi.SelectedValue, "Error");
            MessageBox.Show(this, "sherbimi " + cb_sherbimi.SelectedValue, "Error");
            MessageBox.Show(this, "data " + dt_afati.Value, "Error");

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
                    while (reader.Read())
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

        private void cb_klienti_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show(this, "U zgjodh indeksi: " + cb_klienti.SelectedValue, "Error");
            if ((int)cb_klienti.SelectedValue == 0)
            {
                New_Klient klient = new New_Klient(conn_string);
                klient.ShowDialog();
                ngarko_info_klienti();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hap_cesh_Click(object sender, EventArgs e)
        {
            if (txt_problemi.Text == "")
            {
                MessageBox.Show(this, "Ju lutem jeni nje pershkrim te problemit!", "Kujdes");
                txt_problemi.Focus();
                return;
            }
            string raporti_info = DateTime.Now.ToShortDateString() + ": Hapet ceshtja me pergjegjes " + cb_pergjegjesi.Text + "\n";
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into ceshtja(id_klienti, id_pergjegjesi, id_sherbimi, prioriteti, " +
                                  "statusi, afati_kohor, garanci, raporti, problemi) " +
                    "values(@id_klienti, @id_pergjegjesi, @id_sherbimi, @prioriteti, " +
                                  "@statusi, @afati, @garanci, @raporti, @problemi); " +
                    "Select CAST(scope_identity() AS int);";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_klienti", cb_klienti.SelectedValue);
                cmd.Parameters.AddWithValue("@id_pergjegjesi", cb_pergjegjesi.SelectedValue);
                cmd.Parameters.AddWithValue("@id_sherbimi", cb_sherbimi.SelectedValue);
                cmd.Parameters.AddWithValue("@prioriteti", cb_prioriteti.SelectedValue);
                cmd.Parameters.AddWithValue("@statusi", 1);
                cmd.Parameters.AddWithValue("@afati", dt_afati.Value);
                cmd.Parameters.AddWithValue("@garanci", chb_garancia.Checked); 
                cmd.Parameters.AddWithValue("@raporti", raporti_info);
                cmd.Parameters.AddWithValue("@problemi", txt_problemi.Text);

                try
                {
                    conn.Open();
                    string id_ceshtje = cmd.ExecuteScalar().ToString();
                    Klient klient = (Klient)cb_klienti.SelectedItem;
                    string email = klient.Emri.Split(':')[1].Trim();
                    MessageBox.Show(this, "emaili eshte " + email, "SUKSES");
                    Mailer mailer = new Mailer();
                    mailer.Dergo_email(email, Tipi.id_ceshtje, id_ceshtje, cb_sherbimi.Text);
                    MessageBox.Show(this, "Ceshtja u hap me sukses!", "SUKSES");
                    groupBox1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }

        }

        private void btn_cesh_re_Click(object sender, EventArgs e)
        {
            New_Ceshtje new_ticket = new New_Ceshtje(conn_string);
            this.Visible = false;
            new_ticket.ShowDialog();
            this.Close();
        }
    }
}
