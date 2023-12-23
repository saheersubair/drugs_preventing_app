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

namespace Drugs_Preventing_Administor_App
{
    public partial class ChangePassword : Form
    {
        int pid;

        public ChangePassword(int pid2)
        {
            pid = pid2;
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
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
                string sql = "SELECT * FROM AdminTable WHERE PoliceID = '" + pid + "'";
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

                            string sql2 = "UPDATE AdminTable SET Password = '" + textBox2.Text + "'";
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            con.Open();
            string sql = "SELECT * FROM AdminTable WHERE PoliceID = '" + pid + "'";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string post = dr["Position"].ToString();
                con.Close();
                if (post == "DIG")
                {
                    this.Hide();
                    MenuAdmin menuAdmin = new MenuAdmin(pid);
                    menuAdmin.Show();
                }
                else if (post == "Constable")
                {
                    this.Hide();
                    MenuUser menuUser = new MenuUser(pid);
                    menuUser.Show();
                }
                else
                {
                    this.Hide();
                    MenuUser menuUser = new MenuUser(pid);
                    menuUser.Show();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}

