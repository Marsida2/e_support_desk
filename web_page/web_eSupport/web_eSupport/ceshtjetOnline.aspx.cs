using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace web_eSupport
{
    public partial class ceshtjetOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_klienti"] == null)
                Response.Redirect("Login.aspx");
            update_faqen();
        }

        //lexo te dhenat ne databaze
        private SqlDataReader lexo_ceshtjetDB()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "analize_ceshtjesh_tegjitha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", Session["id_klienti"]);

            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                id_tbody.InnerHtml = "Error: " + ex.Message;
            }
            conn.Close();
            return reader;
        }

        private string formato_te_dhenat(SqlDataReader reader)
        {
            StringBuilder sb = new StringBuilder();

            if(reader != null)
            {
                while(reader.Read())
                {
                    sb.AppendLine("<tr>");
                    sb.AppendLine("<td>" + reader["lloji"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["pershkrimi"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["pergjegjesi"].ToString() + "</td>");
                    sb.AppendLine("<td>" + reader["afati_kohor"].ToString() + "</td>");
                    sb.AppendLine("</tr>");
                }
                reader.Close();
            }
            return sb.ToString();
        }

        private void update_faqen()
        {
            id_tbody.Controls.Add(new LiteralControl(formato_te_dhenat(lexo_ceshtjetDB())));
        }
    }
}