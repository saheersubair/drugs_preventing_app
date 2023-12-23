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
namespace Drugs_Preventing_Administor_App
{
    public partial class VictimComplain : Form
    {
        int pid;
        public VictimComplain(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public void Rreset()
        {
            cbProvince.Text = "";
            victimid.Text = "";
            userid.Text = "";
        }

        private void PersonComplain_Load(object sender, EventArgs e)
        {
            con.Open();

            string sql = "SELECT * FROM ComplainVictimTbl";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();



            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["FirstName"].ToString());
                table.SubItems.Add(dr["SecondName"].ToString());
                table.SubItems.Add(dr["FullName"].ToString());
                table.SubItems.Add(dr["TPNo"].ToString());
                table.SubItems.Add(dr["Province"].ToString());
                table.SubItems.Add(dr["District"].ToString());
                table.SubItems.Add(dr["City"].ToString());
                table.SubItems.Add(dr["Village"].ToString());
                table.SubItems.Add(dr["Address"].ToString());
                table.SubItems.Add(dr["Image"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complains complains = new Complains(pid);
            complains.Show();

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (victimid.Text != "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainVictimTbl WHERE (VictimID = '" + victimid.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["FirstName"].ToString());
                    table.SubItems.Add(dr["SecondName"].ToString());
                    table.SubItems.Add(dr["FullName"].ToString());
                    table.SubItems.Add(dr["TPNo"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (victimid.Text != "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainVictimTbl WHERE (VictimID = '" + victimid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["FirstName"].ToString());
                    table.SubItems.Add(dr["SecondName"].ToString());
                    table.SubItems.Add(dr["FullName"].ToString());
                    table.SubItems.Add(dr["TPNo"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (victimid.Text == "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainVictimTbl WHERE ( UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["FirstName"].ToString());
                    table.SubItems.Add(dr["SecondName"].ToString());
                    table.SubItems.Add(dr["FullName"].ToString());
                    table.SubItems.Add(dr["TPNo"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (victimid.Text == "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainVictimTbl";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["FirstName"].ToString());
                    table.SubItems.Add(dr["SecondName"].ToString());
                    table.SubItems.Add(dr["FullName"].ToString());
                    table.SubItems.Add(dr["TPNo"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            
            else
            {
                MessageBox.Show("Record Not Found");
                Rreset();
                con.Open();

                string sql = "SELECT * FROM ComplainVictimTbl";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["FirstName"].ToString());
                    table.SubItems.Add(dr["SecondName"].ToString());
                    table.SubItems.Add(dr["FullName"].ToString());
                    table.SubItems.Add(dr["TPNo"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Rreset();

            pictureBox1.Image = null;
            tbVictimID.Text = "";
            tbUserID.Text = "";
            tbFName.Text = "";
            tbSName.Text = "";
            tbFullName.Text = "";
            tbTpno.Text = "";
            tbProvince.Text = "";
            tbDistrict.Text = "";
            tbCity.Text = "";
            tbVillage.Text = "";
            tbAddress.Text = "";
            tbDate.Text = "";

            con.Open();

            string sql = "SELECT * FROM ComplainVictimTbl";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["VictimID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["FirstName"].ToString());
                table.SubItems.Add(dr["SecondName"].ToString());
                table.SubItems.Add(dr["FullName"].ToString());
                table.SubItems.Add(dr["TPNo"].ToString());
                table.SubItems.Add(dr["Province"].ToString());
                table.SubItems.Add(dr["District"].ToString());
                table.SubItems.Add(dr["City"].ToString());
                table.SubItems.Add(dr["Village"].ToString());
                table.SubItems.Add(dr["Address"].ToString());
                table.SubItems.Add(dr["Image"].ToString());
                table.SubItems.Add(dr["Date"].ToString());



                listView1.Items.Add(table);

            }

            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem srecord = listView1.SelectedItems[0];
                    tbVictimID.Text = srecord.SubItems[0].Text;
                    tbUserID.Text = srecord.SubItems[1].Text;
                    tbFName.Text = srecord.SubItems[2].Text;
                    tbSName.Text = srecord.SubItems[3].Text;
                    tbFullName.Text = srecord.SubItems[4].Text;
                    tbTpno.Text = srecord.SubItems[5].Text;
                    tbProvince.Text = srecord.SubItems[6].Text;
                    tbDistrict.Text = srecord.SubItems[7].Text;
                    tbCity.Text = srecord.SubItems[8].Text;
                    tbVillage.Text = srecord.SubItems[9].Text;
                    tbAddress.Text = srecord.SubItems[10].Text;
                    tbDate.Text = srecord.SubItems[12].Text;

                    con.Open();
                    string sql = "SELECT Image FROM ComplainVictimTbl WHERE VictimID = '" + tbVictimID.Text + "'";
                    com = new SqlCommand(sql, con);
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        try
                        {
                            if (dr["Image"].ToString() != null)
                            {
                                byte[] img = (byte[])dr["Image"];

                                con.Close();

                                if (img == null)
                                {
                                    pictureBox1.Image = null;
                                }
                                else
                                {
                                    MemoryStream msr = new MemoryStream(img);
                                    pictureBox1.Image = Image.FromStream(msr);

                                }
                            }
                            else
                            {
                                con.Close();
                            }

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        con.Close();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
