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
    public partial class OtherComplain : Form
    {
        int pid;
        public OtherComplain(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand com;
        DataSet ds;

        public void Rreset()
        {
            
            otherid.Text = "";
            userid.Text = "";
        }

        private void OtherComplain_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM ComplainOtherTbl";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();



            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["Title"].ToString());
                table.SubItems.Add(dr["Info"].ToString());
                table.SubItems.Add(dr["Image"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complains complains = new Complains(pid);
            complains.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbProvince.Text != "" && otherid.Text != "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (Province = '" + cbProvince.Text + "' AND OtherID = '" + otherid.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && otherid.Text != "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (Province = '" + cbProvince.Text + "' AND OtherID = '" + otherid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && otherid.Text == "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (Province = '" + cbProvince.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && otherid.Text == "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (Province = '" + cbProvince.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && otherid.Text != "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (OtherID = '" + otherid.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && otherid.Text != "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (OtherID = '" + otherid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
                    table.SubItems.Add(dr["Image"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && otherid.Text == "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainOtherTbl WHERE (UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
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

                string sql = "SELECT * FROM ComplainOtherTbl";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Title"].ToString());
                    table.SubItems.Add(dr["Info"].ToString());
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

            tbOtherID.Text = "";
            tbUserID.Text = "";
            tbTitle.Text = "";
            tbInfo.Text = "";
            tbDate.Text = "";
            pictureBox1.Image = null;

            con.Open();

            string sql = "SELECT * FROM ComplainOtherTbl";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["OtherID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["Title"].ToString());
                table.SubItems.Add(dr["Info"].ToString());
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
                    tbOtherID.Text = srecord.SubItems[0].Text;
                    tbUserID.Text = srecord.SubItems[1].Text;
                    tbTitle.Text = srecord.SubItems[2].Text;
                    tbInfo.Text = srecord.SubItems[3].Text;
                    
                    tbDate.Text = srecord.SubItems[5].Text;
                    

                    con.Open();
                    string sql = "SELECT Image FROM ComplainOtherTbl WHERE OtherID = '" + tbOtherID.Text + "'";
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

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show(er.Message);
                        }
                    }
                    else
                    {

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
