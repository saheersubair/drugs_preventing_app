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

namespace Starting_Interface
{
    public partial class ProfileSettings : Form
    {
        string username;
        int userid;

        public ProfileSettings(string username2)
        {
            username = username2;
            userid = int.Parse(username);
            InitializeComponent();
        }
        

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Your Old Password");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter A New Password To Change");
            }
            else
            {
                con.Open();
                string sql = "SELECT * FROM Usertbl WHERE UserID = '" + userid + "'";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    string oldp = dr["Password"].ToString();

                    if (textBox1.Text == oldp)
                    {
                        con.Close();

                        DialogResult dialogResult = MessageBox.Show("Are You Sure To Chnage Your Password", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (dialogResult == DialogResult.Yes)
                        {
                            con.Open();

                            string sql2 = "UPDATE Usertbl SET Password = '" + textBox2.Text + "' WHERE UserID = '" + userid + "' ";
                            com = new SqlCommand(sql2, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Password Updated Successfully");
                            textBox1.Text = "";
                            textBox2.Text = "";

                            con.Close();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Old Password Is Incorrect");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }

                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbDeletePassword.Text == "")
            {
                MessageBox.Show("Enter Your Password");

            }
            
            else
            {
                con.Open();
                string sql = "SELECT * FROM Usertbl WHERE UserID = '" + userid + "'";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    string oldp = dr["Password"].ToString();

                    if (tbDeletePassword.Text == oldp)
                    {
                        con.Close();

                        DialogResult result = MessageBox.Show("Are You Sure To Delete Your Account", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            string sql1 = "UPDATE UserTbl SET UserName = '', Password = '' WHERE UserID = '"+userid+"'";
                            con.Open();

                            com = new SqlCommand(sql1, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("User Deleted Successfully");
                            con.Close();
                            tbDeletePassword.Text = "";

                            this.Hide();
                            Login_Form login = new Login_Form();
                            login.Show();

                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter A Correct Password");
                        tbDeletePassword.Text = "";
                    }

                }
            }
    }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(username);
            menu.Show();
        }
    }    
}
