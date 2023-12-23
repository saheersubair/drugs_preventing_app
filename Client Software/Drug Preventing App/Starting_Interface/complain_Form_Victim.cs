using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;


namespace Starting_Interface
{
    public partial class complain_Form_Victim : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        Image image;
        String username;
        string imageloc;

        public complain_Form_Victim(String username2)
        {
            InitializeComponent();
            username = username2;
        }
        private void initializeconbobox()
        {
          
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg; *.jpeg; *.bmp; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Image Has Been Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                imageloc = openFileDialog1.FileName.ToString();

                image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Continue? /n You Can't Make Any Changes After Continuing.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            String fname = tbFName.Text, lname = tbSName.Text, fullname = tbFullName.Text, province = cbProvince.Text, district = cbDistrict.Text,
                   city = tbCity.Text, village = tbVillage.Text, address = tbAddress.Text;
            int tpno;
            String date = DateTime.Now.ToShortDateString();

            if (result == DialogResult.Yes && fname != "" && province != "" && district != "" && city != "")
            {
                byte[] img = null;
                FileStream fs = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                tpno = int.Parse(tbTNumber.Text);
                int userid = int.Parse(username);

                con.Open();

                string sql = @"INSERT INTO ComplainVictimTbl (UserID, FirstName, SecondName, FullName, TPNo, Province, District, City, Village, Address, Image, Date)
                             VALUES ('"+userid+"','" + fname+ "','"+lname+ "','"+fullname+"','"+tpno+"','"+province+"','"+district+"','"+city+"','"+village+"','"+address+ "',@img,'" + date+"')";

                com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@img", img));
                com.ExecuteNonQuery();

                con.Close();

                this.Hide();
                ThankYou_Final thank = new ThankYou_Final(username);
                thank.Show();


            }

            else if (result == DialogResult.No )
            {

            }

            else
            {
                MessageBox.Show("You Have To Fill The Informations With A Red Star", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menu = new Menu(username);

            menu.Show();
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void complain_Form_Person1_Load(object sender, EventArgs e)
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
