using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_support_desk
{
    public partial class Ceshtje : Form
    {
        private string conn_string;
        private int id_perdorues;
        private int id_ceshtje = 0;
        public Ceshtje(string conn_str, int id)
        {
            InitializeComponent();
            conn_string = conn_str;
            id_perdorues = id;
        }

   
        private void Ceshtje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.punonjes_info' table. You can move, or remove it, as needed.
            this.punonjes_infoTableAdapter.Fill(this.e_supportDataSet.punonjes_info);
            // TODO: This line of code loads data into the 'e_supportDataSet.punonjesi' table. You can move, or remove it, as needed.
            this.punonjesiTableAdapter.Fill(this.e_supportDataSet.punonjesi);
            // TODO: This line of code loads data into the 'e_supportDataSet.prioriteti' table. You can move, or remove it, as needed.
            this.prioritetiTableAdapter.Fill(this.e_supportDataSet.prioriteti);
            // TODO: This line of code loads data into the 'e_supportDataSet.statusi' table. You can move, or remove it, as needed.
            this.statusiTableAdapter.Fill(this.e_supportDataSet.statusi);
            update_grid_data();
        }

        private void update_grid_data()
        {
            string query = "Select * from analize_ceshtjesh where id_pergjegjesi = " + id_perdorues;
            if (rb_aktive.Checked)
                query += " and statusi = 1;";
            else if(rb_mbyllur.Checked)
                query += " and statusi = 2;";
            else if(rb_zgjidhur.Checked)
                query += " and statusi = 3;";//faturuar
            else if(rb_vonese.Checked)
            { }
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                grid_analize_ceshtjesh.DataSource = ds.Tables[0];
                grid_analize_ceshtjesh.Columns["id_klienti"].Visible = false;
                grid_analize_ceshtjesh.Columns["id_pergjegjesi"].Visible = false;
                grid_analize_ceshtjesh.Columns["statusi"].Visible = false;
                grid_analize_ceshtjesh.Columns["id_sherbimi"].Visible = false;
                grid_analize_ceshtjesh.Columns["raporti"].Visible = false;
                grid_analize_ceshtjesh.Columns["problemi"].Visible = false;
                grid_analize_ceshtjesh.Columns["id_ceshtje"].HeaderText = "Ceshtja";
                grid_analize_ceshtjesh.Columns["pershkrimi"].HeaderText = "Statusi";
                grid_analize_ceshtjesh.Columns["klienti"].HeaderText = "Klienti";
                grid_analize_ceshtjesh.Columns["sherbimi"].HeaderText = "Sherbimi";
                grid_analize_ceshtjesh.Columns["id_ceshtje"].HeaderText = "Ceshtja";
                grid_analize_ceshtjesh.Columns["garanci"].HeaderText = "Garancia";
                grid_analize_ceshtjesh.Columns["garanci"].HeaderText = "Garancia";
                grid_analize_ceshtjesh.Columns["prioriteti"].HeaderText = "Prioriteti";
                grid_analize_ceshtjesh.Columns["afati_kohor"].HeaderText = "Afati";
            }
        }

        private void rb_aktive_CheckedChanged(object sender, EventArgs e)
        {
            update_grid_data();

        }

        private void rb_mbyllur_CheckedChanged(object sender, EventArgs e)
        {
            update_grid_data();
        }

        private void rb_zgjidhur_CheckedChanged(object sender, EventArgs e)
        {
            update_grid_data();
        }

        private void rb_vonese_CheckedChanged(object sender, EventArgs e)
        {
            update_grid_data();
        }

        private void rb_gjitha_CheckedChanged(object sender, EventArgs e)
        {
            update_grid_data();
            grid_analize_ceshtjesh.Select();
        }


        private void grid_analize_ceshtjesh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_ceshtje = (int)grid_analize_ceshtjesh.SelectedRows[0].Cells["id_ceshtje"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
                id_ceshtje = 0;
                return;
            }
            DataGridViewRow row = grid_analize_ceshtjesh.SelectedRows[0];
            MessageBox.Show("u klik " + row.Cells["id_ceshtje"].Value + " dhe status " + (int)row.Cells["statusi"].Value);
            if ((int)row.Cells["statusi"].Value == 2 || (int)row.Cells["statusi"].Value == 3)
                disable_elementet();
            else
            {
                enable_elementet();
                ka_kerkese_afatzgjatje();
            }
            update_elementet(row);
        }

        private void  disable_elementet()
        {
            if(cb_prioriteti.Enabled)
            {
                cb_prioriteti.Enabled = false;
                cb_statusi.Enabled = false;
                txt_problemi.Enabled = false;
                gb_afatshtyrje.Enabled = false;
                gb_delegim.Enabled = false;
                btn_faturo.Enabled = false;
                btn_update.Enabled = false;
            }
        }

        private void enable_elementet()
        {
            if (!cb_prioriteti.Enabled)
            {
                cb_prioriteti.Enabled = true;
                cb_statusi.Enabled = true;
                txt_problemi.Enabled = true;
                gb_afatshtyrje.Enabled = true;
                gb_delegim.Enabled = true;
                btn_faturo.Enabled = true;
                btn_update.Enabled = true;
            }
        }

        private void update_elementet(DataGridViewRow row)
        {
            cb_prioriteti.SelectedValue = row.Cells["prioriteti"].Value.ToString();
            cb_statusi.SelectedValue = row.Cells["statusi"].Value.ToString();
            txt_problemi.Text = row.Cells["problemi"].Value.ToString();
            cb_pergjegjesit.ResetText();
            dt_kerkese.MinDate = DateTime.Parse(row.Cells["afati_kohor"].Value.ToString());
        }

        private void btn_kthehu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(this, "Ju lutem konfirmoni ndryshimet e kryera!",
                "Konfirmoni ndryshimet", MessageBoxButtons.YesNo))
            {
                string info_update = grid_analize_ceshtjesh.SelectedRows[0].Cells["raporti"].Value.ToString();
                info_update += DateTime.Now.ToShortDateString() + ": Ceshtja merr statusin " + cb_statusi.Text + "\n";
                
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Update ceshtja set statusi=@statusi, prioriteti=@prioriteti, problemi=@shenimet, raporti=@info_update " +
                                        "where id_ceshtje=@id_ceshtje;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_ceshtje", id_ceshtje);
                    cmd.Parameters.AddWithValue("@statusi", cb_statusi.SelectedValue);
                    cmd.Parameters.AddWithValue("@prioriteti", cb_prioriteti.SelectedValue);
                    cmd.Parameters.AddWithValue("@problemi", txt_problemi.Text);
                    cmd.Parameters.AddWithValue("@info_update", info_update);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        update_grid_data();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                        return;
                    }
                }
            }
        }

        private void btn_shtyj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into krk_sh_afati values(@id_ceshtje, null, @afati_ri) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_ceshtje", id_ceshtje);
                cmd.Parameters.AddWithValue("@afati_ri", dt_kerkese.Value);
                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                    gb_afatshtyrje.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        private void ka_kerkese_afatzgjatje()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select COUNT(*) from krk_sh_afati where id_ceshtje=@id_ceshtje and pranuar is null;";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_ceshtje", id_ceshtje);
                try
                {
                    conn.Open();
                    int rows_affected = (int)cmd.ExecuteScalar();
                    MessageBox.Show(this, "nr i rreshtave te prekur " + rows_affected, "Error");

                    if (rows_affected >= 1)
                        gb_afatshtyrje.Enabled = false;
                    else
                        gb_afatshtyrje.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

      
        private void btn_delego_Click(object sender, EventArgs e)
        {
            if((int)cb_pergjegjesit.SelectedValue == id_perdorues)
            {
                MessageBox.Show(this, "Smund te delegoni veten!", "Anullim");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show(this, "Jeni te sigurt per ta deleguar pergjegjesine e ceshtjes?", 
                "Konfirmoni Delegimin", MessageBoxButtons.YesNo))
            {
                string punonjes_info_delegimi = grid_analize_ceshtjesh.SelectedRows[0].Cells["raporti"].Value.ToString();
                punonjes_info_delegimi += DateTime.Now.ToShortDateString() + ": Ceshtja delegohet te " + cb_pergjegjesit.Text + "\n";
                //delego ceshtje, kerkese per update
                using (SqlConnection conn = new SqlConnection(conn_string))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Update ceshtja set id_pergjegjesi=@id_pergjegjes, raporti=@info where id_ceshtje=@id_ceshtje;";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_ceshtje", id_ceshtje);
                    cmd.Parameters.AddWithValue("@info", punonjes_info_delegimi);
                    cmd.Parameters.AddWithValue("@id_pergjegjes", cb_pergjegjesit.SelectedValue);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        update_grid_data();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                        return;
                    }
                }
            }
        }

        private void btn_raport_Click(object sender, EventArgs e)
        {

        }
    }
}
