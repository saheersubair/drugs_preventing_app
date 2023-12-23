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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPassword.Text;

            con.Open();

            string SQL = "SELECT * FROM AdminTable WHERE Username = '" + name + "' ";
            com = new SqlCommand(SQL, con);
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                string u = dr["Username"].ToString();
                string p = dr["Password"].ToString();
                string pid3 = dr["PoliceID"].ToString();
                string position = dr["Position"].ToString();
                int pid = int.Parse(pid3);

                if (tbPassword.Text == p)
                {
                    if (position == "DIG")
                    {
                        this.Hide();
                        MenuAdmin menu = new MenuAdmin(pid);
                        menu.Show();
                    }
                    else if (position == "Constable")
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
                else
                {
                    DialogResult result = MessageBox.Show("Password is Incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbName.Text = null;
                    tbPassword.Text = null;
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("UserName is Incorrect", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbName.Text = null;
                tbPassword.Text = null;
            }

            con.Close();

        }
    }
}
