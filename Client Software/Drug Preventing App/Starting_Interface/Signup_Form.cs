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
    public partial class Signup_Form : Form
    {
        public Signup_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Enter An Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Enter A Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbIdno.Text == "")
            {
                MessageBox.Show("Enter Your ID No", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Sql = "SELECT * FROM UserTbl WHERE UserName = '" + tbUsername.Text + "'";
                con.Open();

                com = new SqlCommand(Sql, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Username Already Exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.Text = "";
                }
                else
                {
                    con.Close();

                    con.Open();

                    String sql = "SELECT * FROM UserTbl WHERE IDNo = '" + tbIdno.Text + "'";
                    com = new SqlCommand(sql, con);
                    dr = com.ExecuteReader();

                    if (dr.Read())
                    {
                        if(dr["UserName"].ToString() == "" && dr["Password"].ToString() == "")
                        {
                            con.Close();

                            string sql1 = "UPDATE UserTbl SET UserName = '"+tbUsername.Text+"', Password = '"+tbPassword.Text+"' WHERE IDNo = '" + tbIdno.Text + "'";
                            con.Open();

                            com = new SqlCommand(sql1, con);
                            com.ExecuteNonQuery();
                            this.Hide();
                            Login_Form login = new Login_Form();
                            login.Show();
                            MessageBox.Show("Account Created Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("ID Number Already Exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        con.Close();
                        con.Open();

                        String sql1 = "INSERT INTO UserTbl (IDNo,UserName,Password) VALUES ('" + tbIdno.Text + "','" + tbUsername.Text + "','" + tbPassword.Text + "')";
                        com = new SqlCommand(sql1, con);
                        com.ExecuteNonQuery();


                        con.Close();

                        this.Hide();
                        Login_Form login = new Login_Form();
                        login.Show();

                        MessageBox.Show("Account Created Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    con.Close();
                }

                con.Close();
            }
        }
    }
}
