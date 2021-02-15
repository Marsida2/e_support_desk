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
    public partial class Menu : Form
    {
        private string conn_string;
        private int id_perdoruesi;
        private int roli;
        public Menu(int id, string conn_str)
        {
            InitializeComponent();
            id_perdoruesi = id;
            conn_string = conn_str;
            get_roli();
            lbl_update();

            //ndalo aksesin e plote te cdo punonjesi
            if(roli != 1)
            {
                btn_regj_pun.Enabled = false;
                btn_raporte.Enabled = false;
            }
        }

        //metoda qe shkruan emrin dhe rolin e perdoruesit aktual ne dritaren Menu
        private void lbl_update()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "Select CONCAT(emri, ' ', mbiemri) from punonjesi " +
                                   "where id_punonjesi=@id";
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", id_perdoruesi);

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "Select pozicioni from roli where vlera=@id_roli";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@id_roli", id_perdoruesi);

                try
                {
                    conn.Open();
                    lbl_perdoruesi.Text = (string)cmd1.ExecuteScalar();
                    lbl_roli.Text = (string)cmd2.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }

        private void get_roli()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select id_roli from punonjesi where id_punonjesi = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id_perdoruesi);

                try
                {
                    conn.Open();
                    roli = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error");
                    return;
                }
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "Id: " + id_perdoruesi, "welcome");
            Mailer mailer = new Mailer();
            mailer.Fillo();
        }

        private void btn_regj_pun_Click(object sender, EventArgs e)
        {
            New_Perdorues wind_new_perd = new New_Perdorues(conn_string);
            this.Visible = false;
            wind_new_perd.ShowDialog();
            this.Visible = true;
        }


        private void btn_regj_sher_Click(object sender, EventArgs e)
        {
            New_Sherbim wind_new_sher = new New_Sherbim(conn_string, roli);
            this.Visible = false;
            wind_new_sher.ShowDialog();
            this.Visible = true;
        }


        private void btn_regj_paj_Click(object sender, EventArgs e)
        {
            New_Pajisje wind_new_paj = new New_Pajisje(conn_string, roli);
            this.Visible = false;
            wind_new_paj.ShowDialog();
            this.Visible = true;
        }

        private void btn_dil_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Dispose();
        }

        private void btn_shitje_Click(object sender, EventArgs e)
        {
            Faturim fat = new Faturim(conn_string, id_perdoruesi);
            this.Visible = false;
            fat.ShowDialog();
            this.Visible = true;
        }

        private void btn_hap_cesh_Click(object sender, EventArgs e)
        {
            New_Ceshtje ticket_window = new New_Ceshtje(conn_string);
            this.Visible = false;
            ticket_window.ShowDialog();
            this.Visible = true;
        }

        private void btn_cesh_hapur_Click(object sender, EventArgs e)
        {
            Ceshtje ceshtjet = new Ceshtje(conn_string, id_perdoruesi);
            this.Visible = false;
            ceshtjet.ShowDialog();
            this.Visible = true;
        }
    }
}
