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
    public partial class complain_Form_Other : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        Image image;
        String username;
        string imageloc;


        public complain_Form_Other(String username2)
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
            DialogResult result = MessageBox.Show("Are You Sure To Continue? \n You Can't Make Any Changes After Continuing.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes && tbHeading.Text != null)
            {
                byte[] img = null;
                FileStream fs = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String Title = tbHeading.Text;
                String Info = tbInfo.Text;
                String Date = DateTime.Now.ToShortDateString();
                int userid = int.Parse(username);
                

                con.Open();

                String sql = "INSERT INTO ComplainOtherTbl (UserID,Title, Info, Image, Date) VALUES ('"+userid+"','" + Title + "','" + Info + "',@img,'"+ Date + "')";
                com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@img", img));
                com.ExecuteNonQuery();

                con.Close();

                this.Hide();
                ThankYou_Final thank = new ThankYou_Final(username);
                thank.Show();
            }
            else if (result == DialogResult.No)
            {

            }
            else
            {
                MessageBox.Show("You Have To Fill The Informations With A Red Star", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void complain_Form_Other_Load(object sender, EventArgs e)
        {

        }
    }
}
