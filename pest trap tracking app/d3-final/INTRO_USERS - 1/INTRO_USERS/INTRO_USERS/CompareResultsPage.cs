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
    public partial class CompareResultsPage : Form
    {
        int quanStoat, quanPossum, quanRat, quanOther;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public CompareResultsPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompareResultsPage_Load(object sender, EventArgs e)
        {
            //string seriesName1 = "Quantity";
            //chart1.Series.Add(seriesName1);
            //int landownerID1 = Convert.ToInt32(textBoxLandowner1.Text);

            int landownerID1 = RegisterCatchPage.landownerIDSum;
            textBoxLandowner1.Text = landownerID1.ToString();
            //MessageBox.Show(landownerID1.ToString());
            Set_LandownerID(landownerID1);
            chart1.Series["Landowner 1"].Points.AddXY("Stoat/Weasel", quanStoat);
            chart1.Series["Landowner 1"].Points.AddXY("Possum", quanPossum);
            chart1.Series["Landowner 1"].Points.AddXY("Rat", quanRat);
            chart1.Series["Landowner 1"].Points.AddXY("Other", quanOther);

            int totalQuan1 = quanStoat + quanPossum + quanRat;
            textBoxTotalNumLan1.Text = totalQuan1.ToString();
        }

        private void Set_LandownerID(int landownerID)
        {
            //int quanStoat, quanPossum, quanRat, quanOther, totalQuan;
            //STOAT QUANTITY
            SQL.selectQuery("SELECT COUNT(c.animal_id) FROM catch_in_trap c, trap t, trap_user u, landowner l, animal a WHERE " +
                "c.trap_id = t.trap_id AND t.trap_user_id = u.trap_user_id AND c.animal_id = a.animal_id AND l.landowner_id = u.landowner_id " +
                "AND l.landowner_id = " + landownerID.ToString() + " AND c.animal_id = 1 GROUP BY c.animal_id");
            SQL.read.Read();
            if (!(SQL.read.HasRows)) quanStoat = 0;
            else quanStoat = Convert.ToInt32(SQL.read[0]);

            //POSSUM QUANTITTY
            SQL.selectQuery("SELECT COUNT(c.animal_id) FROM catch_in_trap c, trap t, trap_user u, landowner l, animal a WHERE " +
                "c.trap_id = t.trap_id AND t.trap_user_id = u.trap_user_id AND c.animal_id = a.animal_id AND l.landowner_id = u.landowner_id AND l.landowner_id = "
                + landownerID.ToString() + " AND c.animal_id = 2 GROUP BY c.animal_id");
            SQL.read.Read();
            if (!(SQL.read.HasRows)) quanPossum = 0;
            else quanPossum = Convert.ToInt32(SQL.read[0]);

            //RAT QUANTITTY
            SQL.selectQuery("SELECT COUNT(c.animal_id) FROM catch_in_trap c, trap t, " +
                "trap_user u, landowner l, animal a WHERE c.trap_id = t.trap_id AND t.trap_user_id =" +
                " u.trap_user_id AND c.animal_id = a.animal_id AND l.landowner_id = u.landowner_id AND l.landowner_id = u.landowner_id AND l.landowner_id = "
                + landownerID.ToString() + " AND c.animal_id = 3 GROUP BY c.animal_id");
            SQL.read.Read();
            if (!(SQL.read.HasRows)) quanRat = 0;
            else quanRat = Convert.ToInt32(SQL.read[0]);

            //OTHER QUANTITTY
            SQL.selectQuery("SELECT COUNT(c.animal_id) FROM catch_in_trap c, trap t, trap_user u, landowner l, " +
                "animal a WHERE c.trap_id = t.trap_id AND t.trap_user_id = u.trap_user_id AND c.animal_id = a.animal_id AND " +
                "l.landowner_id = u.landowner_id AND l.landowner_id = " + landownerID.ToString() + " AND c.animal_id > 3 GROUP BY c.animal_id");
            SQL.read.Read();
            if (!(SQL.read.HasRows)) quanOther = 0;
            else quanOther = Convert.ToInt32(SQL.read[0]);


            //TOTAL QUANTITY
            //totalQuan = quanStoat + quanPossum + quanRat;
            //textBoxTotalNum.Text = totalQuan.ToString();

            //chart1.Series["Landowner 1"].Points.AddXY("Stoat/Weasel", quanStoat);
            //chart1.Series["Landowner 1"].Points.AddXY("Possum", quanPossum);
            //chart1.Series["Landowner 1"].Points.AddXY("Rat", quanRat);
            //chart1.Series["Landowner 1"].Points.AddXY("Other", quanOther);
        }

        private void button2_Click(object sender, EventArgs e) //compare button
        {
            try
            {

                chart1.Series.Clear();
                //if (String.IsNullOrEmpty(textBoxLandownerID.Text)))
                string seriesName1 = "Landowner 1";
                chart1.Series.Add(seriesName1);
                int landownerID1 = RegisterCatchPage.landownerIDSum;
                textBoxLandowner1.Text = landownerID1.ToString();
                //MessageBox.Show(landownerID1.ToString());
                Set_LandownerID(landownerID1);
                chart1.Series["Landowner 1"].Points.AddXY("Stoat/Weasel", quanStoat);
                chart1.Series["Landowner 1"].Points.AddXY("Possum", quanPossum);
                chart1.Series["Landowner 1"].Points.AddXY("Rat", quanRat);
                chart1.Series["Landowner 1"].Points.AddXY("Other", quanOther);
                int totalQuan1 = quanStoat + quanPossum + quanRat;
                textBoxTotalNumLan1.Text = totalQuan1.ToString();

                /******************************************************************************************************/

                //chart1.Series.Clear();
                //if (String.IsNullOrEmpty(textBoxLandownerID.Text)))
                string seriesName2 = "Landowner 2";
                chart1.Series.Add(seriesName2);
                int landownerID2 = Convert.ToInt32(textBoxLandowner2.Text);
                Set_LandownerID(landownerID2);
                chart1.Series["Landowner 2"].Points.AddXY("Stoat/Weasel", quanStoat);
                chart1.Series["Landowner 2"].Points.AddXY("Possum", quanPossum);
                chart1.Series["Landowner 2"].Points.AddXY("Rat", quanRat);
                chart1.Series["Landowner 2"].Points.AddXY("Other", quanOther);

                int totalQuan2 = quanStoat + quanPossum + quanRat;
                textBoxTotalNumLan2.Text = totalQuan2.ToString();

                int totalQuanBoth = totalQuan1 + totalQuan2;
                textBoxTotalNumLanBoth.Text = totalQuanBoth.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid landowner ID" + ex);
            }

        }
    }
}
    
