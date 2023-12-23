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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Please Enter An Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please Enter An Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();

                string Sql = "SELECT * FROM UserTbl WHERE UserName = '" + tbUserName.Text + "'";
                cmd = new SqlCommand(Sql, con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string username = dr["UserName"].ToString();
                    string password = dr["Password"].ToString();
                    string userid = dr["UserID"].ToString();

                    if (tbPassword.Text == password)
                    {
                        
                        this.Hide();
                        Menu menu = new Menu(userid);
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPassword.Text = "";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUserName.Text = "";
                    tbPassword.Text = "";
                }

                con.Close();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup_Form signup = new Signup_Form();
            signup.Show();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
