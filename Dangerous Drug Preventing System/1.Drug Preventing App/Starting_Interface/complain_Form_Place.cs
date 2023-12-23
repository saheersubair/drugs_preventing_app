using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Starting_Interface
{
    public partial class complain_Form_Place : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        String username;
        
        public complain_Form_Place(String username2)
        {
            InitializeComponent();
            username = username2;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(username);
            menu.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Continue? \n You Can't Make Any Changes After Continuing.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            String Province = cbProvince.Text, District = cbDistrict.Text, City = tbCity.Text, Village = tbVillage.Text, Address = tbAddress.Text, Info = rtbInfo.Text;

            if (result == DialogResult.Yes && Province != null && District != null && City != null && Info != null)
            {
                
                String Date = DateTime.Now.ToShortDateString();

                con.Open();

                String sql = "INSERT INTO ComplainPlace (Province,District,City,Village,Address,MoreInfo,Date) VALUES ('" + Province + "','" + District + "','" + City + "','" + Village + "','" + Address + "','" + Info + "','" + Date + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                con.Close();

                this.Hide();
                ThankYou_Final thank = new ThankYou_Final(username);
                thank.Show();
            }

            else if (result == DialogResult.Yes && Province == null || District == null || City == null || Info == null)
            {
                MessageBox.Show("You Have To Fill The Informations With A Red Star", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (result == DialogResult.No)
            {

            }
        }

        private void complain_Form_Place_Load(object sender, EventArgs e)
        {

        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProvince.Text)
            {
                case "":
                    cbDistrict.Enabled = false;
                    this.cbDistrict.Items.AddRange(new object[] { "One",
                    ""});
                    break;
                case "Nothern":
                    this.cbDistrict.Items.AddRange(new object[] { "Jaffna",
                    "Kilinochchi",
                    "Mannar",
                    "Mullaitivu",
                    "Vavuniya"});
                    break;
                case "North Western":
                    this.cbDistrict.Items.AddRange(new object[] { "Puttalam",
                    "Kurunegala"});
                    break;
                case "Western":
                    this.cbDistrict.Items.AddRange(new object[] { "Gampaha",
                    "Colombo",
                    "Kalutara"});
                    break;
                case "North Central":
                    this.cbDistrict.Items.AddRange(new object[] { "Anuradhapura",
                    "Polonnaruwa"});
                    break;
                case "Central":
                    this.cbDistrict.Items.AddRange(new object[] { "Kandy",
                    "Matale",
                    "Nuwara Eliya"});
                    break;
                case "Sabragamuwa":
                    this.cbDistrict.Items.AddRange(new object[] { "Kegalle",
                    "Ratnapura"});
                    break;
                case "Eastern":
                    this.cbDistrict.Items.AddRange(new object[] { "Trincomalee",
                    "Batticaloa",
                    "Ampara"});
                    break;
                case "Uva":
                    this.cbDistrict.Items.AddRange(new object[] { "Badulla",
                    "Monaragala"});
                    break;
                case "Southern":
                    this.cbDistrict.Items.AddRange(new object[] { "Hambantota",
                    "Matara",
                    "Galle"});
                    break;



            }
        }
    }
}
