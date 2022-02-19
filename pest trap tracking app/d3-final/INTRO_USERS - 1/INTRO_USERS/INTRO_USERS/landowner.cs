using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRO_USERS
{
    public partial class landowner : Form
    {
        public landowner()
        {
            InitializeComponent();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void landowner_Load(object sender, EventArgs e)
        {
            dataGridViewLandowner.DataSource = GetLandownerData();
        }

        private DataTable GetLandownerData()
        {   SQL.selectQuery("SELECT * FROM landowner");
            DataTable landownerData = new DataTable();
            landownerData.Load(SQL.read);
            return landownerData;
        }

        private void labelLandowner_Click(object sender, EventArgs e)
        {

        }
    }
}
