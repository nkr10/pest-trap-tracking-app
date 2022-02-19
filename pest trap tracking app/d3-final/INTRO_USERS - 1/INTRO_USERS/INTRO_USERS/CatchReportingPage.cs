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
    public partial class CatchReportingPage : Form
    {
        int animalID;

        public CatchReportingPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatchReportingPage_Load(object sender, EventArgs e)
        {
            this.ActiveControl = buttonSubmit;
        }

        private void buttonStoat_Click(object sender, EventArgs e)
        {
        }

        private void buttonPossum_Click(object sender, EventArgs e)
        {
        }

        private void buttonRat_Click(object sender, EventArgs e)
        {
        }

        private void radioButtonStoat_CheckedChanged(object sender, EventArgs e)
        {
            animalID = 01;
            
        }
        
        private void radioButtonPossum_CheckedChanged(object sender, EventArgs e)
        {
            animalID = 02;
        }

        private void radioButtonRat_CheckedChanged(object sender, EventArgs e)
        {
            animalID = 03;
        }

        private void buttonInfoStroat_Click(object sender, EventArgs e)
        {
            stoatInfoPage stoatInfoPage1 = new stoatInfoPage();
            stoatInfoPage1.Show();
            
        }


        public void buttonInfoPossum_Click(object sender, EventArgs e)
        {
            PossumInfoPage possumInfoPage= new PossumInfoPage();
            possumInfoPage.Show();
        }

        private void buttonInfoRat_Click(object sender, EventArgs e)
        {
            RatInfoPage ratInfoPage = new RatInfoPage();
            ratInfoPage.Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {   //catch date(identity), trap id(fk), animal id(fk), manager id(fk)
            int trapID = 0;
            int managerID = LoginPage.managerID; //get manager id from login page
            string catchDate = dateTimePickerCaught.Value.ToString("yyyy-MM-dd").Trim(); //get the date catch is registered
            string animalName = textBoxElseCatch.Text.Trim(); //get text in the textbox
            

            if (!(String.IsNullOrEmpty(textBoxElseCatch.Text))) //if there is something in the textbox
            {
                //make the id = last id in the database + 1
                SQL.selectQuery("SELECT MAX(animal_id) from animal");
                SQL.read.Read();
                animalID = Convert.ToInt32(SQL.read[0]) + 1;
                //animalID = 4;
                SQL.executeQuery("INSERT into animal (animal_id, name) values (" + animalID.ToString() + ", '" + animalName.ToString() + "')");
            }

            else if(!(radioButtonPossum.Checked) || !(radioButtonRat.Checked || !(radioButtonStoat.Checked) && (String.IsNullOrEmpty(textBoxElseCatch.Text))))
            {
                MessageBox.Show("Please input animal caught"); return;
            }

            //if there is input in the textbox, and a button is clicked
            /**else if (!(String.IsNullOrEmpty(textBoxElseCatch.Text)) && (buttonPossumSelected || buttonRatSelected || buttonStoatSelected))
            {
                MessageBox.Show("You may only enter one animal at a time.");
                return;
            }**/

            //else from the radio buttons
            //select trap id of the last record
            SQL.selectQuery("SELECT MAX(trap_id) from trap"); 
            //if (SQL.read.HasRows)
            //{
                SQL.read.Read();
                trapID = Convert.ToInt32(SQL.read[0]);
                //MessageBox.Show("trap id: " + trapID.ToString() + " animal id: " + animalID.ToString() + " manager id: " + managerID); //testing
            //}
            
            //catch_id, catch_date, trap_id, animal_id, manager_id
            SQL.executeQuery("INSERT into catch_in_trap values( '" + catchDate.ToString() + "', " + trapID.ToString() + ", " + animalID.ToString() + ", " + managerID.ToString() + ")");

            this.Hide();
            LandownerSummaryPage landownerSummaryPage1 = new LandownerSummaryPage();
            landownerSummaryPage1.Show();
        }

        private void labelCatchRep_Click(object sender, EventArgs e)
        {

        }
    }
}
