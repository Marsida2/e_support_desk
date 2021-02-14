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
    public partial class Ceshtje : Form
    {
        public Ceshtje(string conn_string)
        {
            InitializeComponent();
        }

        private void ceshtjaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ceshtjaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);

        }

        private void Ceshtje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_supportDataSet.ceshtja' table. You can move, or remove it, as needed.
            this.ceshtjaTableAdapter.Fill(this.e_supportDataSet.ceshtja);
            // TODO: This line of code loads data into the 'e_supportDataSet.ceshtja' table. You can move, or remove it, as needed.
            this.ceshtjaTableAdapter.Fill(this.e_supportDataSet.ceshtja);

        }

        private void ceshtjaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ceshtjaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.e_supportDataSet);

        }
    }
}
