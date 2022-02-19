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
    public partial class LoginPage : Form
    {   public static int managerID;
        public LoginPage()
        {
            InitializeComponent();
            //this line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*'; //password character to hide password characters
            textBoxPassword.MaxLength = 20; //max textbox character count
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            //variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string username = "", password = "";
            
            //firstname = "", lastname = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch //(Exception ex)
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            //(2) SELECT statement getting all data from managers, i.e. SELECT * FROM manager
            SQL.selectQuery("SELECT * FROM manager where name = '" + username.ToString() + "'");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered managers
            if (SQL.read.HasRows)
            {
                SQL.read.Read(); 
                if (password.Equals(SQL.read[2].ToString())) {
                        managerID = Convert.ToInt32(SQL.read[0]);
                        //MessageBox.Show(managerID.ToString()); --working
                        loggedIn = true;
                    }
            }
            else
            {
                MessageBox.Show("No manager have been registered");
                return;
            }

            //if logged in, display a success message
            if (loggedIn)
            {
                this.Hide();
                MessageBox.Show("Successfully logged in as: " + username);
                //landowner formLandowner = new landowner();
                //formLandowner.Show(); //display landowner form
                //initialiseTextBoxes;
                RegisterCatchPage registerCatchPage = new RegisterCatchPage();
                registerCatchPage.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                textBoxUsername.Focus();
            }
        }

    }
}
