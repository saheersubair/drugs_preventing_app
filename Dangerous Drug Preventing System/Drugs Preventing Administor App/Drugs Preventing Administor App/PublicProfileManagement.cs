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
    public partial class PublicProfileManagement : Form
    {
        int pid;

        public PublicProfileManagement(int pid2)
        {
            pid = pid2;
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        private void PublicProfileManagement_Load(object sender, EventArgs e)
        {
            con.Open();

            string sql = "SELECT * FROM UserTbl";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();

            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["UserID"].ToString());
                table.SubItems.Add(dr["IDNo"].ToString());
                table.SubItems.Add(dr["UserName"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {

                string sql = "SELECT * FROM UserTbl WHERE UserID = '" + int.Parse(tbSearch.Text) + "'";
                con.Open();

                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    
                    tbUserID.Text = dr["UserID"].ToString();
                    tbIDNo.Text = dr["IDNo"].ToString();
                    tbUsername.Text = dr["UserName"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Enter A Police ID To Search");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbUserID.Text = "";
            tbUsername.Text = "";
            tbIDNo.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin menu = new MenuAdmin(pid);
            menu.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {

                    ListViewItem srerocord = listView1.SelectedItems[0];
                    tbUserID.Text = srerocord.SubItems[0].Text;
                    tbIDNo.Text = srerocord.SubItems[1].Text;
                    tbUsername.Text = srerocord.SubItems[2].Text;
                    
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
