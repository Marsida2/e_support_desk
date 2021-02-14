using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_eSupport
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            shfaq_sherbimet();
            shfaq_pajisjet();
        }


        private void shfaq_sherbimet()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from sherbimi";
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder karta_sherbimi = new StringBuilder();

            while (reader.Read())
            {
                karta_sherbimi.Append("<div class='col-sm-4 py-2'>");
                karta_sherbimi.Append("<div class='card text-white bg-primary'>");
                karta_sherbimi.Append("<div class='card-body'>");
                karta_sherbimi.Append("<h3 class='card-title'>");
                karta_sherbimi.Append((string)reader["lloji"]);
                karta_sherbimi.Append("</h3><p class='card-text'>Kostoja e sherbimit:\n");
                karta_sherbimi.Append(reader["kostoja"]);
                karta_sherbimi.Append("leke</p>");
                karta_sherbimi.Append("</div></div></div>");
            }
            div_sherbimet.Controls.Add(new LiteralControl(karta_sherbimi.ToString()));
            reader.Close();
            conn.Close();
        }


        private void shfaq_pajisjet()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from pajisja";
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder karta_pajisje = new StringBuilder();

            while (reader.Read())
            {
                karta_pajisje.Append("<div class='col-sm-4 py-2'>");
                karta_pajisje.Append("<div class='card text-white bg-primary'>");
                karta_pajisje.Append("<div class='card-body'>");
                karta_pajisje.Append("<h3 class='card-title'>");
                karta_pajisje.Append((string)reader["emertimi"]);
                karta_pajisje.Append("</h3><p class='card-text'>Kostoja e pajisjes:\n");
                karta_pajisje.Append(reader["cmimi"]);
                karta_pajisje.Append("leke</p>");
                karta_pajisje.Append("</div></div></div>");
            }
            div_pajisjet.Controls.Add(new LiteralControl(karta_pajisje.ToString()));
            reader.Close();
            conn.Close();
        }
    }
}