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
    public partial class ManageUser : Form
    {
        int pid;

        public ManageUser(int pid2)
        {
            InitializeComponent();
            pid = pid2;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        string status;

        public void resetlist()
        {
            con.Open();

            string sql = "SELECT * FROM AdminTable";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["PoliceID"].ToString());
                table.SubItems.Add(dr["FirstName"].ToString());
                table.SubItems.Add(dr["SecondName"].ToString());
                table.SubItems.Add(dr["Username"].ToString());
                table.SubItems.Add(dr["Position"].ToString());
                table.SubItems.Add(dr["AddedBy"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();
        }

        public void resetall()
        {
            tbPoliceID.Enabled = true;
            tbfname.Enabled = false;
            tbsname.Enabled = false;
            tbusername.Enabled = false;
            tbPosition.Enabled = false;
            tbPassword.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            tbAdded.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            tbDate.Visible = false;

            tbPoliceID.Text = "";
            tbfname.Text = "";
            tbsname.Text = "";
            tbusername.Text = "";
            tbPosition.Text = "";
            tbSearch.Text = "";
            tbPassword.Text = "";
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            tbPassword.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            tbAdded.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            tbDate.Visible = false;

            con.Open();

            string sql = "SELECT * FROM AdminTable";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();            

            listView1.Items.Clear();

            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["PoliceID"].ToString());
                table.SubItems.Add(dr["FirstName"].ToString());
                table.SubItems.Add(dr["SecondName"].ToString());
                table.SubItems.Add(dr["Username"].ToString());
                table.SubItems.Add(dr["Position"].ToString());
                table.SubItems.Add(dr["AddedBy"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "SELECT * FROM AdminTable";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["PoliceID"].ToString());
                table.SubItems.Add(dr["FirstName"].ToString());
                table.SubItems.Add(dr["SecondName"].ToString());
                table.SubItems.Add(dr["Username"].ToString());
                table.SubItems.Add(dr["Position"].ToString());
                table.SubItems.Add(dr["AddedBy"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbPoliceID.Text == "")
            {
                MessageBox.Show("Enter The Police ID To Add The New User");
            }
            else
            {
                string sql1 = "SELECT * FROM AdminTable WHERE PoliceID = '" + tbPoliceID.Text + "'";

                con.Open();

                com = new SqlCommand(sql1, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("PoliceID Already Exist");
                }
                else
                {


                    status = "add";

                    tbPoliceID.Enabled = false;
                    tbfname.Enabled = true;
                    tbsname.Enabled = true;
                    tbusername.Enabled = true;
                    tbPosition.Enabled = true;
                    tbPassword.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    label17.Visible = false;
                    label16.Visible = false;
                    tbDate.Visible = false;
                }

                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbPoliceID.Text == "")
            {
                MessageBox.Show("Select An User / Or Type a Police ID To Edit", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql1 = "SELECT * FROM AdminTable WHERE PoliceID = '" + tbPoliceID.Text + "'";

                con.Open();

                com = new SqlCommand(sql1, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    status = "edit";

                    tbPoliceID.Enabled = false;
                    tbfname.Enabled = false;
                    tbsname.Enabled = false;
                    tbusername.Enabled = false;
                    tbPosition.Enabled = true;
                    label15.Visible = true;
                    label14.Visible = true;
                    tbAdded.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    tbDate.Visible = true;

                    tbfname.Text = dr["FirstName"].ToString();
                    tbsname.Text = dr["SecondName"].ToString();
                    tbusername.Text = dr["Username"].ToString();
                    tbPosition.Text = dr["Position"].ToString();
                    tbDate.Text = dr["Date"].ToString();
                }
                else
                {
                    MessageBox.Show("Record Doesn't Exist");
                }

                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbPoliceID.Text == "")
            {
                MessageBox.Show("Select An User To Delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPoliceID.Text == pid.ToString())
            {
                MessageBox.Show("You Can't Delete Your Account, Please Contact A Higher Official To Do This", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql1 = "SELECT * FROM AdminTable WHERE PoliceID = '" + tbPoliceID.Text + "'";

                con.Open();

                com = new SqlCommand(sql1, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {

                    tbPoliceID.Enabled = false;
                    tbfname.Enabled = true;
                    tbsname.Enabled = true;
                    tbusername.Enabled = true;
                    tbPosition.Enabled = true;

                    tbfname.Text = dr["FirstName"].ToString();
                    tbsname.Text = dr["SecondName"].ToString();
                    tbusername.Text = dr["Username"].ToString();
                    tbPosition.Text = dr["Position"].ToString();

                    con.Close();

                    DialogResult result = MessageBox.Show("Are You Sure To Delete This User?", "Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string sql2 = "DELETE FROM AdminTable WHERE PoliceID = '" + tbPoliceID.Text + "'";

                        con.Open();

                        com = new SqlCommand(sql2, con);
                        com.ExecuteNonQuery();

                        con.Close();
                        resetall();
                        resetlist();
                    }
                    else
                    {
                        resetall();
                    }
                }
                else
                {
                    MessageBox.Show("Record Doesn't Exist");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetall();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                int policeid = int.Parse(tbSearch.Text);

                string sql = "SELECT * FROM AdminTable WHERE PoliceID = '" + policeid + "'";
                con.Open();

                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    label15.Visible = true;
                    label14.Visible = true;
                    tbAdded.Visible = true;
                    tbPoliceID.Enabled = false;
                    tbfname.Enabled = false;
                    tbsname.Enabled = false;
                    tbusername.Enabled = false;
                    tbPosition.Enabled = false;

                    tbPoliceID.Text = dr["PoliceID"].ToString();
                    tbfname.Text = dr["FirstName"].ToString();
                    tbsname.Text = dr["SecondName"].ToString();
                    tbusername.Text = dr["Username"].ToString();
                    tbPosition.Text = dr["Position"].ToString();
                    tbAdded.Text = dr["AddedBy"].ToString();
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "add")
            {
                if (tbfname.Text != "" && tbPoliceID.Text != "" && tbsname.Text != "" && tbusername.Text != "" && tbPassword.Text != "" && tbPosition.Text != "")
                {
                    string sql2 = "SELECT * FROM AdminTable WHERE Username = '" + tbusername.Text + "'";

                    con.Open();

                    com = new SqlCommand(sql2, con);
                    dr = com.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Username Already Exist");
                        tbusername.Text = "";
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are You Sure To Create This New User", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            con.Close();
                            con.Open();

                            String date = DateTime.Now.ToShortDateString();

                            string sql = @"INSERT INTO AdminTable (PoliceID,FirstName,SecondName,Username,Password,Position,AddedBy,Date) VALUES ('" + int.Parse(tbPoliceID.Text) + "','" + tbfname.Text + "','" + tbsname.Text + "','" + tbusername.Text + "','" + tbPassword.Text + "','" + tbPosition.Text + "','" + pid + "','" + date + "')";
                            com = new SqlCommand(sql, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("User Created Successfully");
                            resetall();
                            con.Close();
                            resetlist();
                            resetall();


                            con.Close();
                        }
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Fill All The Records And Continue");
                }

            }
            else if (status == "edit")
            {
                if (tbPosition.Text != "")
                {
                    DialogResult result2 = MessageBox.Show("Are You Sure To Edit This User", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result2 == DialogResult.Yes)
                    {
                        String date = DateTime.Now.ToShortDateString();

                        string sql2 = "UPDATE AdminTable SET Position = '" + tbPosition.Text + "',Date = '" + date + "',AddedBy = '" + pid + "' WHERE PoliceID = '" + tbPoliceID.Text + "' ";

                        con.Open();

                        com = new SqlCommand(sql2, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("User Updated Successfully");
                        resetall();
                        con.Close();
                        resetlist();

                        con.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing Was Changed To Save", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(listView1.SelectedItems.Count > 0)
                {
                    resetall();
                    label15.Visible = true;
                    label14.Visible = true;
                    tbAdded.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    tbDate.Visible = true;
                    tbPoliceID.Enabled = false;

                    ListViewItem srerocord = listView1.SelectedItems[0];
                    tbPoliceID.Text = srerocord.SubItems[0].Text;
                    tbfname.Text = srerocord.SubItems[1].Text;
                    tbsname.Text = srerocord.SubItems[2].Text;
                    tbusername.Text = srerocord.SubItems[3].Text;
                    tbPosition.Text = srerocord.SubItems[4].Text;
                    tbAdded.Text = srerocord.SubItems[5].Text;
                    tbDate.Text = srerocord.SubItems[6].Text;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
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
    }
}
