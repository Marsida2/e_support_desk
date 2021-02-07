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
        }

        private void btn_regj_pun_Click(object sender, EventArgs e)
        {
            New_Perdorues wind_new_perd = new New_Perdorues(conn_string);
            wind_new_perd.ShowDialog();
        }

        private void btn_dil_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Visible = false;
            login.ShowDialog();
            this.Dispose();
        }
    }
}
