using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Menu(int id, string conn_str)
        {
            InitializeComponent();
            id_perdoruesi = id;
            conn_string = conn_str;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Id: "+id_perdoruesi, "welcome");
        }
    }
}
