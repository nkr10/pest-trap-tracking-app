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
    public partial class LandownerSummaryPage : Form
    {
        public static int landownerIDStat;
        public LandownerSummaryPage()
        {
            InitializeComponent();
        }

        private void listBoxLandownerSum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LandownerSummaryPage_Load(object sender, EventArgs e)
        {
            
        }

        private void LandownerSummaryPage_Load_1(object sender, EventArgs e)
        {
            try
            {
                int landownerID = RegisterCatchPage.landownerIDSum;
                string landownerName = "";
                //MessageBox.Show(landownerID.ToString());
                SQL.selectQuery("SELECT landowner_id, firstname, lastname FROM landowner WHERE landowner_id = " + landownerID.ToString());
                textBoxLandownerID.Text = landownerID.ToString();


                SQL.read.Read();
                landownerName = SQL.read[1].ToString() + " " + SQL.read[2].ToString();
                textBoxLandownerName.Text = landownerName;


                SQL.selectQuery("SELECT catch_date, a.name, trap_type.name FROM catch_in_trap c, animal a, trap_type, trap_user u, trap t, landowner l WHERE " +
                    "t.trap_id = c.trap_id AND l.landowner_id = " + landownerID.ToString() + " AND u.landowner_id = l.landowner_id AND trap_type.trap_type_id = t.trap_type_id" +
                    " AND a.animal_id = c.animal_id AND u.trap_user_id = t.trap_user_id");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        String[] registerDateTime = SQL.read[0].ToString().Split(' ');
                        String registerDate = registerDateTime[0];
                        String animalName = SQL.read[1].ToString();
                        String trapType = SQL.read[2].ToString();

                        ListViewItem catchItem = new ListViewItem(registerDate, 0);
                        catchItem.SubItems.Add(animalName);
                        catchItem.SubItems.Add(trapType);
                        listViewLandSum.Items.Add(catchItem);
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddCatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterCatchPage registerCatchPage1 = new RegisterCatchPage();
            registerCatchPage1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatisticsPage statisticsPage = new StatisticsPage();
            statisticsPage.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                listViewLandSum.Items.Clear();
                int landownerIDtest = Convert.ToInt32(textBoxLandownerID.Text);

                string landownerName = "";
                SQL.selectQuery("SELECT landowner_id, firstname, lastname FROM landowner WHERE landowner_id = " + landownerIDtest.ToString());


                SQL.read.Read();
                if (SQL.read.HasRows)
                {

                    
                    landownerIDStat = landownerIDtest;
                    landownerName = SQL.read[1].ToString() + " " + SQL.read[2].ToString();
                    textBoxLandownerName.Text = landownerName;


                    SQL.selectQuery("SELECT catch_date, a.name, trap_type.name FROM catch_in_trap c, animal a, trap_type, trap_user u, trap t, landowner l WHERE " +
                        "t.trap_id = c.trap_id AND l.landowner_id = " + landownerIDtest.ToString() + " AND u.landowner_id = l.landowner_id AND trap_type.trap_type_id = t.trap_type_id" +
                        " AND a.animal_id = c.animal_id AND u.trap_user_id = t.trap_user_id");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            String[] registerDateTime = SQL.read[0].ToString().Split(' ');
                            String registerDate = registerDateTime[0];
                            String animalName = SQL.read[1].ToString();
                            String trapType = SQL.read[2].ToString();

                            ListViewItem catchItem = new ListViewItem(registerDate, 0);
                            catchItem.SubItems.Add(animalName);
                            catchItem.SubItems.Add(trapType);

                            listViewLandSum.Items.Add(catchItem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Landowner ID does not exist in the database");
                    textBoxLandownerID.Clear();
                    textBoxLandownerName.Clear();
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
