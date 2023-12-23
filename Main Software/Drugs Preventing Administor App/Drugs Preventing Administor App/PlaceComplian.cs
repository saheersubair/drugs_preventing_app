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
    public partial class PlaceComplian : Form
    {
        int pid;
        public PlaceComplian(int pid2)
        {
            InitializeComponent();
            pid = pid2;

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0O97TN\ZAHEERSQL;Initial Catalog=DrugPreventingApp;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand com;
        SqlDataReader dr;
        DataSet ds;

        public void Rreset()
        {
            cbProvince.Text = "";
            placeid.Text = "";
            userid.Text = "";
        }

        private void PersonFilter_Load(object sender, EventArgs e)
        {


            tbPlaceID.Enabled = false;
            tbUserID.Enabled = false;
            tbProvince.Enabled = false;
            tbDistrict.Enabled = false;
            tbCity.Enabled = false;
            tbDate.Enabled = false;
            tbAddress.Enabled = false;
            tbVillage.Enabled = false;
            tbMoreInfo.Enabled = false;

            con.Open();

            string sql = "SELECT * FROM ComplainPlace";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();



            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["Province"].ToString());
                table.SubItems.Add(dr["District"].ToString());
                table.SubItems.Add(dr["City"].ToString());
                table.SubItems.Add(dr["Village"].ToString());
                table.SubItems.Add(dr["Address"].ToString());
                table.SubItems.Add(dr["MoreInfo"].ToString());
                table.SubItems.Add(dr["Date"].ToString());

                listView1.Items.Add(table);

            }

            con.Close();

        }






        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbProvince.Text != "" && placeid.Text != "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Province = '" + cbProvince.Text + "' AND Place_ID = '" + placeid.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && placeid.Text != "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Province = '" + cbProvince.Text + "' AND Place_ID = '" + placeid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && placeid.Text == "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Province = '" + cbProvince.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text != "" && placeid.Text == "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Province = '" + cbProvince.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && placeid.Text != "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Place_ID = '" + placeid.Text + "' AND UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && placeid.Text != "" && userid.Text == "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (Place_ID = '" + placeid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
            else if (cbProvince.Text == "" && placeid.Text == "" && userid.Text != "")
            {
                con.Open();

                string sql = "SELECT * FROM ComplainPlace WHERE (UserID = '" + userid.Text + "')";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
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

                string sql = "SELECT * FROM ComplainPlace";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();

                listView1.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                    table.SubItems.Add(dr["UserID"].ToString());
                    table.SubItems.Add(dr["Province"].ToString());
                    table.SubItems.Add(dr["District"].ToString());
                    table.SubItems.Add(dr["City"].ToString());
                    table.SubItems.Add(dr["Village"].ToString());
                    table.SubItems.Add(dr["Address"].ToString());
                    table.SubItems.Add(dr["MoreInfo"].ToString());
                    table.SubItems.Add(dr["Date"].ToString());

                    listView1.Items.Add(table);

                }

                con.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Rreset();

            tbPlaceID.Text = "";
            tbUserID.Text = "";
            tbProvince.Text = "";
            tbDistrict.Text = "";
            tbVillage.Text = "";
            tbCity.Text = "";
            tbAddress.Text = "";
            tbMoreInfo.Text = "";


            con.Open();

            string sql = "SELECT * FROM ComplainPlace";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();

            listView1.Items.Clear();
            while (dr.Read())
            {
                ListViewItem table = new ListViewItem(dr["Place_ID"].ToString());
                table.SubItems.Add(dr["UserID"].ToString());
                table.SubItems.Add(dr["Province"].ToString());
                table.SubItems.Add(dr["District"].ToString());
                table.SubItems.Add(dr["City"].ToString());
                table.SubItems.Add(dr["Village"].ToString());
                table.SubItems.Add(dr["Address"].ToString());
                table.SubItems.Add(dr["MoreInfo"].ToString());
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
                    tbPlaceID.Text = srecord.SubItems[0].Text;
                    tbUserID.Text = srecord.SubItems[1].Text;
                    tbProvince.Text = srecord.SubItems[2].Text;
                    tbDistrict.Text = srecord.SubItems[3].Text;
                    tbCity.Text = srecord.SubItems[4].Text;
                    tbVillage.Text = srecord.SubItems[5].Text;
                    tbAddress.Text = srecord.SubItems[6].Text;
                    tbMoreInfo.Text = srecord.SubItems[7].Text;
                    tbDate.Text = srecord.SubItems[8].Text;

                }

            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Complains complains = new Complains(pid);
            complains.Show();
        }
    }
}
        